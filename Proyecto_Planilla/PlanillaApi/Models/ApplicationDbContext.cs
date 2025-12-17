using Microsoft.EntityFrameworkCore;
using PlanillaApi.Models;

namespace PlanillaApi.Models
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext (
            DbContextOptions<ApplicationDbContext> options ) : base( options ) 
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Empresa> Empresas => Set<Empresa>();
        public DbSet<Empleado> Empleados => Set<Empleado>();
    }
}
