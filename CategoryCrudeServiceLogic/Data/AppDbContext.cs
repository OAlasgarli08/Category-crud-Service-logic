using CategoryCrudeServiceLogic.Models;
using Microsoft.EntityFrameworkCore;

namespace CategoryCrudeServiceLogic.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) { }

        public DbSet<Slider> Sliders {  get; set; } 
    }
}
