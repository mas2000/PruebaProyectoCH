using AppClientesEntities;
using System.Data.SqlClient;

public static class ProductoData
{
    // Método para obtener un producto por su ID
    public static Producto ObtenerProducto(int id)
    {
        using (var context = new SGContexto())
        {
            return context.Productos.FirstOrDefault(p => p.Id == id);
        }
    }

    // Método para listar todos los productos
    public static List<Producto> ListarProductos()
    {
        using (var context = new SGContexto())
        {
            return context.Productos.ToList();
        }
    }

    // Método para crear un nuevo producto
    public static void CrearProducto(Producto producto)
    {
        using (var context = new SGContexto())
        {
            context.Productos.Add(producto);
            context.SaveChanges();
        }
    }

    // Método para modificar un producto existente
    public static void ModificarProducto(int id, Producto productoNuevo)
    {
        using (var context = new SGContexto())
        {
            var productoActual = context.Productos.FirstOrDefault(p => p.Id == id);
            if (productoActual != null)
            {
                productoActual.Descripcion = productoNuevo.Descripcion;
                productoActual.Costo = productoNuevo.Costo;
                productoActual.PrecioVenta = productoNuevo.PrecioVenta;
                productoActual.Stock = productoNuevo.Stock;
                productoActual.IdUsuario = productoNuevo.IdUsuario;
                context.SaveChanges();
            }
        }
    }

    // Método para eliminar un producto por su ID
    public static void EliminarProducto(int id)
    {
        using (var context = new SGContexto())
        {
            var productoActual = context.Productos.FirstOrDefault(p => p.Id == id);
            if (productoActual != null)
            {
                context.Productos.Remove(productoActual);
                context.SaveChanges();
            }
        }
    }
}