using AppClientesEntities;
using System.Data.SqlClient;

public static class ProductoVendidoData
{
    // Método para obtener un producto vendido por su ID
    public static ProductoVendido ObtenerProductoVendido(int id)
    {
        using (var context = new SGContexto())
        {
            return context.ProductosVendidos.FirstOrDefault(pv => pv.Id == id);
        }
    }

    // Método para listar todos los productos vendidos
    public static List<ProductoVendido> ListarProductosVendidos()
    {
        using (var context = new SGContexto())
        {
            return context.ProductosVendidos.ToList();
        }
    }

    // Método para crear un nuevo producto vendido
    public static void CrearProductoVendido(ProductoVendido productoVendido)
    {
        using (var context = new SGContexto())
        {
            context.ProductosVendidos.Add(productoVendido);
            context.SaveChanges();
        }
    }

    // Método para modificar un producto vendido existente
    public static void ModificarProductoVendido(int id, ProductoVendido productoVendidoNuevo)
    {
        using (var context = new SGContexto())
        {
            var productoVendidoActual = context.ProductosVendidos.FirstOrDefault(pv => pv.Id == id);
            if (productoVendidoActual != null)
            {
                productoVendidoActual.IdVenta = productoVendidoNuevo.IdVenta;
                productoVendidoActual.Stock = productoVendidoNuevo.Stock;
                productoVendidoActual.IdProducto = productoVendidoNuevo.IdProducto;
                context.SaveChanges();
            }
        }
    }

    // Método para eliminar un producto vendido por su ID
    public static void EliminarProductoVendido(int id)
    {
        using (var context = new SGContexto())
        {
            var productoVendidoActual = context.ProductosVendidos.FirstOrDefault(pv => pv.Id == id);
            if (productoVendidoActual != null)
            {
                context.ProductosVendidos.Remove(productoVendidoActual);
                context.SaveChanges();
            }
        }
    }
}


