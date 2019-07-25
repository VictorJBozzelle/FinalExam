using FinalExam.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FinalExam.Data
{
    public class DealershipContext : IdentityDbContext
    {
        public DealershipContext(DbContextOptions<DealershipContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }

    }
}
