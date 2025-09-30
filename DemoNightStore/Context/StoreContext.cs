using DemoNightStore.Entities;
using Microsoft.EntityFrameworkCore;

namespace DemoNightStore.Context
{
    public class StoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Initial Catalog= StoreDemoNewDb; Integrated Security= true;");
        }
        public DbSet<Order> Orders { get; set; }
    }
}
