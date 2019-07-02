using System.Linq;
using FinalExam.Models;
using System.Collections.Generic;

namespace FinalExam.Data
{
    public class EFVehicleRepository : IVehicleRepository
    {
        private DealershipContext context;

        public EFVehicleRepository(DealershipContext ctx)
        {
            context=ctx;
        }

        public IEnumerable<Vehicle> GetVehicles => context.Vehicles;

        public void SaveVehicle(Vehicle vehicle)
        {
            if( vehicle.VehicleId==0 )
            {
                context.Vehicles.Add(vehicle);
            }
            else
            {
                Vehicle dbEntry = context.Vehicles
                    .FirstOrDefault(v => v.VehicleId==vehicle.VehicleId);
                if( dbEntry!=null )
                {
                    dbEntry.Year=vehicle.Year;
                    dbEntry.Make=vehicle.Make;
                    dbEntry.Model=vehicle.Model;
                    dbEntry.Mileage=vehicle.Mileage;
                }
            }
            context.SaveChanges();
        }

        public Vehicle DeleteVehicle(int id)
        {
            Vehicle dbEntry = context.Vehicles
                .FirstOrDefault(v => v.VehicleId==id);
            if( dbEntry!=null )
            {
                context.Vehicles.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
