using AppClientesData;
using AppClientesEntities;

namespace AppClienteBussiness
{
    public static class ProductoVendidoBussiness
    {
        // Métodos para operaciones relacionadas con ProductoVendido
        public static ProductoVendido ObtenerProductoVendido(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            return AppClienteEF.ProductoVendidoData.ObtenerProductoVendido(id);
        }

        public static List<ProductoVendido> ListarProductosVendidos()
        {
            // Llamar al método correspondiente en la capa de Datos
            return AppClienteEF.ProductoVendidoData.ListarProductosVendidos();
        }

        public static void CrearProductoVendido(ProductoVendido productoVendido)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.ProductoVendidoData.CrearProductoVendido(productoVendido);
        }

        public static void ModificarProductoVendido(int id, ProductoVendido productoVendidoNuevo)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.ProductoVendidoData.ModificarProductoVendido(id, productoVendidoNuevo);
        }

        public static void EliminarProductoVendido(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.ProductoVendidoData.EliminarProductoVendido(id);
        }
    }
}
