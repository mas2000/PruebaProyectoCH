using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AppClientesUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerVentas()
        {
            var ventas = VentaBussiness.ListarVentas();
            return Ok(ventas);
        }

        [HttpPost]
        public IActionResult CrearVenta([FromBody] Venta venta)
        {
            VentaBussiness.CrearVenta(venta);
            return Ok("Venta creada exitosamente");
        }

        [HttpPut("{id}")]
        public IActionResult ModificarVenta(int id, [FromBody] Venta ventaNueva)
        {
            VentaBussiness.ModificarVenta(id, ventaNueva);
            return Ok("Venta modificada exitosamente");
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarVenta(int id)
        {
            VentaBussiness.EliminarVenta(id);
            return Ok("Venta eliminada exitosamente");
        }
    }
}
