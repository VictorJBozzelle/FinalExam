using System.Linq;
using FinalExam.Data;
using FinalExam.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
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

