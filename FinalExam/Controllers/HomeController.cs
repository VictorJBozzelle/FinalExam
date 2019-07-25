using System.Linq;
using FinalExam.Data;
using FinalExam.Models;
using Microsoft.AspNetCore.Mvc;
using FinalExam.Models.ViewModels;
using Microsoft.AspNetCore.Authorization;

namespace FinalExam.Controllers
{
    [Authorize]
    [AutoValidateAntiforgeryToken]
    public class HomeController : Controller
    {
        private IVehicleRepository repository;

        public HomeController(IVehicleRepository repo)
        {
            repository = repo;
        }

        [AllowAnonymous]
        public ViewResult Index() => View(new VehicleListViewModel
        { Vehicles = repository.GetVehicles });

        public ViewResult Create() => View("Edit", new Vehicle());

        public ViewResult Edit(int VehicleId) =>
           View(repository.GetVehicles.FirstOrDefault(v => v.VehicleId == VehicleId));

        [HttpPost]
        public IActionResult Edit(Vehicle Vehicle)
        {
            if(ModelState.IsValid)
            {
                repository.SaveVehicle(Vehicle);
                TempData["message"] = $"{Vehicle.Make + " " + Vehicle.Model} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(Vehicle);
            }
        }

        [HttpPost]
        public IActionResult Delete(int VehicleId)
        {
            Vehicle deletedVehicle = repository.DeleteVehicle(VehicleId);
            if(deletedVehicle != null)
            {
                TempData["message"] = $"{deletedVehicle.Make + " " + deletedVehicle.Model} was deleted";
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult SeedDatabase()
        {
            SeedData.EnsurePopulated(HttpContext.RequestServices);
            return RedirectToAction(nameof(Index));
        }
    }
}