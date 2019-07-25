using FinalExam.Data;
using Microsoft.AspNetCore.Mvc;
using FinalExam.Models.ViewModels;

namespace FinalExam.Views.Shared.Components
{
    public class VehicleCountViewComponent : ViewComponent
    {
        private IVehicleRepository repository;

        public VehicleCountViewComponent(IVehicleRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            var model = new VehicleListViewModel
            {
                Vehicles = repository.GetVehicles
            };
            return View(model);
        }
    }
}

