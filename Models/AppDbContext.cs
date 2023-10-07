using Microsoft.EntityFrameworkCore;

namespace DotNet_OneToMany_Dish.Models
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Chef> Chefs { get; set; }

        public DbSet<Dish> Dishes { get; set; }
    }
}
