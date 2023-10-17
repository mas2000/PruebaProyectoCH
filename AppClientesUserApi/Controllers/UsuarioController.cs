using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace AppClientesUserApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        [HttpGet]
        public IActionResult ObtenerUsuarios()
        {
            var usuarios = UsuarioBussiness.ListarUsuarios();
            return Ok(usuarios);
        }

        [HttpPost]
        public IActionResult CrearUsuario([FromBody] Usuario usuario)
        {
            UsuarioBussiness.CrearUsuario(usuario);
            return Ok("Usuario creado exitosamente");
        }

        [HttpPut("{id}")]
        public IActionResult ModificarUsuario(int id, [FromBody] Usuario usuarioNuevo)
        {
            UsuarioBussiness.ModificarUsuario(id, usuarioNuevo);
            return Ok("Usuario modificado exitosamente");
        }

        [HttpDelete("{id}")]
        public IActionResult EliminarUsuario(int id)
        {
            UsuarioBussiness.EliminarUsuario(id);
            return Ok("Usuario eliminado exitosamente");
        }
    }
}