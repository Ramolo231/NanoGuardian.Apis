using Microsoft.AspNetCore.Mvc;
using NanoGuardian.Api.Models;

namespace NanoGuardian.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AlertasController : ControllerBase
    {
        [HttpPost]
        public IActionResult RecibirAlerta([FromBody] Alerta nuevaAlerta)
        {
            if (string.IsNullOrEmpty(nuevaAlerta.Paciente))
            {
                return BadRequest("El nombre del paciente es obligatorio.");
            }

            Console.WriteLine($"🚨 ALERTA RECIBIDA: Paciente {nuevaAlerta.Paciente} cayó con {nuevaAlerta.FuerzaImpactoG}G");

            return Ok(new { mensaje = "Alerta procesada con éxito", codigo = 200 });
        }
    }
    
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