using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AppClientesUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerClientes()
        {
            var clientes = ClienteBussiness.ListarClientes();
            return Ok(clientes);
        }

        [HttpGet("{id}")]
        public IActionResult ObtenerClientePorId(int id)
        {
            var cliente = ClienteBussiness.ObtenerCliente(id);
            if (cliente == null)
            {
                return NotFound("Cliente no encontrado");
            }
            return Ok(cliente);
        }

        [HttpPost]
        public IActionResult CrearCliente([FromBody] Cliente cliente)
        {
            ClienteBussiness.CrearCliente(cliente);
            return Ok("Cliente creado exitosamente");
        }

        [HttpPut("{id}")]
        public IActionResult ModificarCliente(int id, [FromBody] Cliente clienteNuevo)
        {
            ClienteBussiness.ModificarCliente(id, clienteNuevo);
            return Ok("Cliente modificado exitosamente");
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarCliente(int id)
        {
            ClienteBussiness.EliminarCliente(id);
            return Ok("Cliente eliminado exitosamente");
        }
    }
}
