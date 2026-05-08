using Microsoft.EntityFrameworkCore;
using lab1projekt.models;

namespace lab1projekt.Data
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext(DbContextOptions<RestaurantDbContext> options)
            : base(options)
        {
        }

        public DbSet<MenuCategory> MenuCategories { get; set; }

        public DbSet<MenuItem> MenuItems { get; set; }
    }
}