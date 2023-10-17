using AppClientesData;
using AppClientesEntities;


namespace AppClienteBussiness
{
    public static class ProductoBussiness
    {
        // Métodos para operaciones relacionadas con Producto
        public static Producto ObtenerProducto(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            return AppClienteEF.ProductoData.ObtenerProducto(id);
        }

        public static List<Producto> ListarProductos()
        {
            // Llamar al método correspondiente en la capa de Datos
            return AppClienteEF.ProductoData.ListarProductos();
        }

        public static void CrearProducto(Producto producto)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.ProductoData.CrearProducto(producto);
        }

        public static void ModificarProducto(int id, Producto productoNuevo)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.ProductoData.ModificarProducto(id, productoNuevo);
        }

        public static void EliminarProducto(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            AppClienteEF.ProductoData.EliminarProducto(id);
        }
    }
}
