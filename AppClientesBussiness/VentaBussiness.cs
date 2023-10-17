using AppClientesData;
using AppClientesEntities;
namespace AppClienteBussiness
{
    public static class VentaBussiness
    {
        // Métodos para operaciones relacionadas con Venta
        public static Venta ObtenerVenta(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            return AppClienteEF.VentaData.ObtenerVenta(id);
        }

        public static List<Venta> ListarVentas()
        {
            // Llamar al método correspondiente en la capa de Datos
            return AppClienteEF.VentaData.ListarVentas();
        }

        public static void CrearVenta(Venta venta)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.VentaData.CrearVenta(venta);
        }

        public static void ModificarVenta(int id, Venta ventaNueva)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.VentaData.ModificarVenta(id, ventaNueva);
        }

        public static void EliminarVenta(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.VentaData.EliminarVenta(id);
        }
    }
}
