using CarBook.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace CarBook.DataAccessLayer.Concrete
{
    public class CarBookContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;initial catalog=CarBookDB;integrated security=true;trusted_connection=true;encrypt=false");
        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Price> Prices { get; set; }
    }
}