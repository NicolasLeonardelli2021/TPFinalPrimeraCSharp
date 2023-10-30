using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionEntities;
using SistemaGestionBussiness;
namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        [HttpGet (Name = "GetUsuarios")]
        public IEnumerable<Usuario> Get()
        {
            return UsuarioBussiness.GetUsuarios()
                .ToArray();
        }

        [HttpDelete (Name = "EliminarUsuario")]
        public void Delete([FromBody] int  id)
        {
            UsuarioBussiness.EliminarUsuario(id);
        }

        [HttpPut (Name = "EditarUsuario")]
        public void Put([FromBody] Usuario usuario)
        {
            UsuarioBussiness.EditarUsuario(usuario);
        }

        [HttpPost (Name ="crearUsuario")]
        public void Post([FromBody] Usuario usuario)
        {
            UsuarioBussiness.crearUsuario(usuario);
        }

    }
}
