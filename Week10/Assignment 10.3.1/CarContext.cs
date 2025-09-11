using Assignment_10._3._1;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_10._3._1
{
    public class CarContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source = DESKTOP1;initial catalog=CarInventory; " +
                "integrated security=True;encrypt=False;trustservercertificate=True;MultipleActiveResultSets=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Car>().HasData
                (
                    new Car { Vin = "A1", Manufacture = "Ford", Model = "Escape", Price = 30000 },
                    new Car { Vin = "A2", Manufacture = "Ford", Model = "Escape", Price = 30000 },
                    new Car { Vin = "A3", Manufacture = "Ford", Model = "Explorer", Price = 40000 },
                    new Car { Vin = "A4", Manufacture = "Honda", Model = "Civic", Price = 35000 }
                );
        }

    }
}
