using SistemaGestionData;
using SistemaGestionEntities;

namespace SistemaGestionBussiness
{
    public class UsuarioBussiness
    {
        public static void crearUsuario(Usuario usuario)
        {
             UsuarioData.crearUsuario(usuario);
        }

        public static List<Usuario> GetUsuarios()
        {
            return UsuarioData.ListarUsuarios();
        }

        public static void EditarUsuario(Usuario usuario)
        {
            UsuarioData.ModificarUsuario(usuario);
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            UsuarioData.EliminarUsuario(usuario);
        }
    }
}