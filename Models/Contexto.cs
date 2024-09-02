using Microsoft.EntityFrameworkCore;

namespace ExamenAjax.Models
{
    public class Contexto:DbContext

    {
        public DbSet<Producto> Productos { get; set; }

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Producto>()
        //        .HasKey(p => p.ProductoID); // Define la clave primaria explícitamente
        //}
    }
}
