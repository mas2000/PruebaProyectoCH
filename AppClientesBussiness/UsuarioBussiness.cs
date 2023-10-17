using AppClientesData;
using AppClientesEntities;

namespace AppClienteBussiness
{
    public static class UsuarioBussiness
    {
        // Métodos para operaciones relacionadas con Usuario
        public static Usuario ObtenerUsuario(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            return UsuarioData.ObtenerUsuario(id);
        }

        public static List<Usuario> ListarUsuarios()
        {
            // Llamar al método correspondiente en la capa de Datos
            return UsuarioData.ListarUsuarios();
        }

        public static void CrearUsuario(Usuario usuario)
        {
            // Llamar al método correspondiente en la capa de Datos
            UsuarioData.CrearUsuario(usuario);
        }

        public static void ModificarUsuario(int id, Usuario usuarioNuevo)
        {
            // Llamar al método correspondiente en la capa de Datos
            UsuarioData.ModificarUsuario(id, usuarioNuevo);
        }

        public static void EliminarUsuario(int id)
        {
            // Llamar al método correspondiente en la capa de Datos
            UsuarioData.EliminarUsuario(id);
        }
    }
}
