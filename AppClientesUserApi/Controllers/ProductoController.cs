using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AppClientesUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerProductos()
        {
            var productos = ProductoBussiness.ListarProductos();
            return Ok(productos);
        }

        [HttpPost]
        public IActionResult CrearProducto([FromBody] Producto producto)
        {
            ProductoBussiness.CrearProducto(producto);
            return Ok("Producto creado exitosamente");
        }

        [HttpPut("{id}")]
        public IActionResult ModificarProducto(int id, [FromBody] Producto productoNuevo)
        {
            ProductoBussiness.ModificarProducto(id, productoNuevo);
            return Ok("Producto modificado exitosamente");
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarProducto(int id)
        {
            ProductoBussiness.EliminarProducto(id);
            return Ok("Producto eliminado exitosamente");
        }
    }
}
