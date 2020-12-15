using Microsoft.EntityFrameworkCore;
using PC3_PROGRA.Models;

namespace PC3_PROGRA.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }

        public ApplicationDbContext(DbContextOptions dco) : base(dco){
            
        }
    }
}