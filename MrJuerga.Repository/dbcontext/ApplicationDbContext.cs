using MrJuerga.Entity;
using Microsoft.EntityFrameworkCore;

namespace MrJuerga.Repository.dbcontext
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Boleta> Boletas { get; set; }
        public DbSet<DetalleBoleta> DetalleBoletas { get; set; }
        public DbSet<BoletaDTO> BoletaDTOs { get; set; }
        public DbSet<DetalleBoletaDTO> DetalleBoletaDTOs { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}
