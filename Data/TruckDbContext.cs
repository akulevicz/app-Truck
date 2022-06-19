using Microsoft.EntityFrameworkCore;
using app_Truck.Models;

namespace app_Truck.Data
{
    public class TruckDbContext : DbContext
    {
        public TruckDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Truck> Trucks { get; set; }
    }
}