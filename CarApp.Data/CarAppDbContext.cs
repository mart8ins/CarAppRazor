using CarApp.Data.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace CarApp.Data
{
    public class CarAppDbContext : DbContext
    {
        public CarAppDbContext(DbContextOptions<CarAppDbContext> options) : base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
