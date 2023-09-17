using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarApp.Data;

namespace CarApp.Data
{
    public class CarAppDbContextFactory : IDesignTimeDbContextFactory<CarAppDbContext>
    {
        public CarAppDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CarAppDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\projectmodels;Database=CarApp_db;Trusted_Connection=True;MultipleActiveResultSets=true");
            return new CarAppDbContext(optionsBuilder.Options);
        }
    }
}
