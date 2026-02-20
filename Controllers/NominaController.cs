using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TSS.Api.Models;

namespace TSS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NominaController : ControllerBase
    {

        [HttpPost]
        public IActionResult RecibirNomina([FromBody] NominaDto nomina)
        {
            return Ok(new
            {
                mensaje = "Nomina recibida correctamente",
                asiento = nomina.NoAsiento
            });
        }
    }

}