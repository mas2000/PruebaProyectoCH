using AppClientesEntities;
using System.Data.SqlClient;

namespace SistemaGestionEF
{
    // Clase que representa el contexto de la base de datos
    public class SGContexto : DbContext
    {
        // DbSet para la entidad Usuario
        public DbSet<Usuario> Usuarios { get; set; }
        // DbSet para la entidad Producto
        public DbSet<Producto> Productos { get; set; }
        // DbSet para la entidad Venta
        public DbSet<Venta> Ventas { get; set; }
        // DbSet para la entidad ProductoVendido
        public DbSet<ProductoVendido> ProductosVendidos { get; set; }

        // Método para configurar las opciones del contexto
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                // Configuración para utilizar SQL Server como proveedor de base de datos
                optionsBuilder.UseSqlServer(
                    @"Server=(localdb)\mssqllocaldb;Database=SistemaGestionEF;Trusted_Connection=True");
            }
            catch (Exception excepcion)
            {
                Console.WriteLine(excepcion);
            }
        }
    }
}
