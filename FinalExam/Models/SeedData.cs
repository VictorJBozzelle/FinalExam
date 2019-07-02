using System;
using System.Linq;
using FinalExam.Data;
using Microsoft.Extensions.DependencyInjection;

namespace FinalExam.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IServiceProvider services)
        {
            DealershipContext context = services.GetRequiredService<DealershipContext>();
            if(!context.Vehicles.Any())
            {
                context.Vehicles.AddRange(
                     new Vehicle {  Year=2002, Make="Acura", Model="RSX", Mileage=12345 },
                new Vehicle { Year=1999, Make="Honda", Model="Civic" },
                new Vehicle {  Year=2000, Make="Nissan", Model="Skyline", Mileage=5 },
                new Vehicle {  Year=2012, Make="Ford", Model="F150", Mileage=89999 });

                context.SaveChanges();
            }
        }
    }
}
