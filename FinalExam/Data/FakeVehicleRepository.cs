using FinalExam.Models;
using System.Collections.Generic;

namespace FinalExam.Data
{
    public class FakeVehicleRepository //: IVehicleRepository
    {
        public IEnumerable<Vehicle> GetAll()
        {
            return new List<Vehicle>
            {
                new Vehicle { VehicleId = 1, Year = 2002, Make = "Acura", Model = "RSX", Mileage = 12345 },
                new Vehicle { VehicleId = 2, Year = 1999, Make = "Honda", Model = "Civic" },
                new Vehicle { VehicleId = 3, Year = 2000, Make = "Nissan", Model = "Skyline", Mileage = 5 },
                new Vehicle { VehicleId = 4, Year = 2012, Make = "Ford", Model = "F150", Mileage = 89999 }
            };
        }

        public void Create(Vehicle vehicle)
        {
            //TODO
        }

        public void Delete(int id)
        {
            //TODO
        }

        public void Update(Vehicle vehicle)
        {
            //TODO
        }
    }
}
