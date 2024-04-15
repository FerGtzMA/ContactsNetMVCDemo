using CrudContactsNet.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudContactsNet.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        // Agregar los modelos
        public DbSet<Contacto> Contacto { get; set; }
    }
}
