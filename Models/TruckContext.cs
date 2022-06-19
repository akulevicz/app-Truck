
using Microsoft.EntityFrameworkCore;


namespace app_Truck.Models{
public class TruckContext : DbContext {
    public TruckContext(DbContextOptions<TruckContext> options): base (options)  
	{
    }
    
    public DbSet<Truck> Truck  {get; set;} 
}

}