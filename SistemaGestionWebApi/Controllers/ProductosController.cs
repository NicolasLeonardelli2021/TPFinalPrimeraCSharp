using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        [HttpGet(Name = "GetProductos")]
        public IEnumerable<Producto> Get()
        {
            return ProductoBussiness.GetProductos()
                .ToArray();
        }

        [HttpDelete(Name = "EliminarProducto")]
        public void Delete([FromBody] Producto producto)
        {
            ProductoBussiness.EliminarProducto(producto);
        }

        [HttpPut(Name = "ModificarProducto")]
        public void Put([FromBody] Producto producto)
        {
            ProductoBussiness.ModificarProducto(producto);
        }

        [HttpPost(Name = "crearUsuario")]
        public void Post([FromBody] Producto producto)
        {
            ProductoBussiness.crearProducto(producto);
        }
    }
}
