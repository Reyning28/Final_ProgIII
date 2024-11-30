using Microsoft.EntityFrameworkCore;
using RedadasMigracion.Models;

namespace RedadasMigracion.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<PersonaDetenida> PersonasDetenidas { get; set; } = null!;

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
