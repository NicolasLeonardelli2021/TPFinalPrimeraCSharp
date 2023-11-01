using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBussiness;
using SistemaGestionEntities;

namespace SistemaGestionWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        [HttpGet(Name = "GetVentas")]
        public IEnumerable<Venta> Get()
        {
            return VentaBussiness.ListarVenta()
                .ToArray();
        }

        [HttpPost(Name = "AltaVenta")]
        public void Post([FromBody] Venta venta)
        {
            VentaBussiness.AltaVenta(venta);
        }


    }
}
