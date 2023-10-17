using AppClientesEntities;
using System.Data.SqlClient;

namespace SistemaGestionEF
{
    // Operaciones relacionadas con la entidad Usuario
    public static class UsuarioData
    {
        // Método para obtener un usuario por su ID
        public static Usuario ObtenerUsuario(int id)
        {
            using (var context = new SGContexto())
            {
                return context.Usuarios.FirstOrDefault(u => u.Id == id);
            }
        }

        // Método para listar todos los usuarios
        public static List<Usuario> ListarUsuarios()
        {
            using (var context = new SGContexto())
            {
                return context.Usuarios.ToList();
            }
        }

        // Método para crear un nuevo usuario
        public static void CrearUsuario(Usuario usuario)
        {
            using (var context = new SGContexto())
            {
                context.Usuarios.Add(usuario);
                context.SaveChanges();
            }
        }

        // Método para modificar un usuario existente
        public static void ModificarUsuario(int id, Usuario usuarioNuevo)
        {
            using (var context = new SGContexto())
            {
                var usuarioActual = context.Usuarios.FirstOrDefault(u => u.Id == id);
                if (usuarioActual != null)
                {
                    usuarioActual.Nombre = usuarioNuevo.Nombre;
                    usuarioActual.NombreUsuario = usuarioNuevo.NombreUsuario;
                    usuarioActual.Apellido = usuarioNuevo.Apellido;
                    usuarioActual.Mail = usuarioNuevo.Mail;
                    usuarioActual.Contrasenia = usuarioNuevo.Contrasenia;
                    context.SaveChanges();
                }
            }
        }

        // Método para eliminar un usuario por su ID
        public static void EliminarUsuario(int id)
        {
            using (var context = new SGContexto())
            {
                var usuarioActual = context.Usuarios.FirstOrDefault(u => u.Id == id);
                if (usuarioActual != null)
                {
                    context.Usuarios.Remove(usuarioActual);
                    context.SaveChanges();
                }
            }
        }
    }

}
