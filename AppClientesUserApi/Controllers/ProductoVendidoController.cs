using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AppClientesUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoVendidoController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerProductosVendidos()
        {
            var productosVendidos = ProductoVendidoBussiness.ListarProductosVendidos();
            return Ok(productosVendidos);
        }

        [HttpPost]
        public IActionResult CrearProductoVendido([FromBody] ProductoVendido productoVendido)
        {
            ProductoVendidoBussiness.CrearProductoVendido(productoVendido);
            return Ok("Producto vendido creado exitosamente");
        }

        [HttpPut("{id}")]
        public IActionResult ModificarProductoVendido(int id, [FromBody] ProductoVendido productoVendidoNuevo)
        {
            ProductoVendidoBussiness.ModificarProductoVendido(id, productoVendidoNuevo);
            return Ok("Producto vendido modificado exitosamente");
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarProductoVendido(int id)
        {
            ProductoVendidoBussiness.EliminarProductoVendido(id);
            return Ok("Producto vendido eliminado exitosamente");
        }
    }
}
