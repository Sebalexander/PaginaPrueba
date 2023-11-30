using Microsoft.EntityFrameworkCore;
using PaginaPrueba.Models;

namespace PaginaPrueba.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        // Aquí se llaman a los modelos creados.

        public DbSet<Profesional> Profesional { get; set; }
    }
}