using Microsoft.EntityFrameworkCore;

namespace Busco.Models
{
    public class BuscoContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Comprador> Compradores { get; set; }
        public DbSet<Solicitud> Solicitudes { get; set; }

        public BuscoContext(DbContextOptions dco) : base(dco) {

        }
    }
}