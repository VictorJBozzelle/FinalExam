using System;
using System.Linq;
using FinalExam.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinalExam.Data
{
    public class DealershipContext : IdentityDbContext
    {
        public DealershipContext(DbContextOptions<DealershipContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set;}

    }
}
