using Microsoft.AspNetCore.Mvc;
using NanoGuardian.Api.Models;

namespace NanoGuardian.Api.Controllers
{
   
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        [HttpGet("ultima")]
        public IActionResult ObtenerUltimaAlerta()
        {
            var alerta = new Alerta
            {
                Paciente = "Juan Pérez (Real)",
                FuerzaImpactoG = 5,
                Estado = "¡Caída Detectada en API!"
            };

            return Ok(alerta);
        }
    }
}
