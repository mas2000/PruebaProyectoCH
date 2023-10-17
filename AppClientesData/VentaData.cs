using AppClientesEntities;
using System.Data.SqlClient;

public static class VentaData
{
    // Método para obtener una venta por su ID
    public static Venta ObtenerVenta(int id)
    {
        using (var context = new SGContexto())
        {
            return context.Ventas.FirstOrDefault(v => v.Id == id);
        }
    }

    // Método para listar todas las ventas
    public static List<Venta> ListarVentas()
    {
        using (var context = new SGContexto())
        {
            return context.Ventas.ToList();
        }
    }

    // Método para crear una nueva venta
    public static void CrearVenta(Venta venta)
    {
        using (var context = new SGContexto())
        {
            context.Ventas.Add(venta);
            context.SaveChanges();
        }
    }

    // Método para modificar una venta existente
    public static void ModificarVenta(int id, Venta ventaNueva)
    {
        using (var context = new SGContexto())
        {
            var ventaActual = context.Ventas.FirstOrDefault(v => v.Id == id);
            if (ventaActual != null)
            {
                ventaActual.Comentarios = ventaNueva.Comentarios;
                ventaActual.IdUsuario = ventaNueva.IdUsuario;
                context.SaveChanges();
            }
        }
    }

    // Método para eliminar una venta por su ID
    public static void EliminarVenta(int id)
    {
        using (var context = new SGContexto())
        {
            var ventaActual = context.Ventas.FirstOrDefault(v => v.Id == id);
            if (ventaActual != null)
            {
                context.Ventas.Remove(ventaActual);
                context.SaveChanges();
            }
        }
    }
}
}
