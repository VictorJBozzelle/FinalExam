using FinalExam.Models;
using System.Collections.Generic;

namespace FinalExam.Data
{
    public interface IVehicleRepository
    {
        IEnumerable<Vehicle> GetVehicles { get; }

        void SaveVehicle(Vehicle vehicle);

        Vehicle DeleteVehicle(int id);
    }
}
