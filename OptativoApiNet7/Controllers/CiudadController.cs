using Microsoft.AspNetCore.Mvc;
using Servicios.ContactosService;

namespace OptativoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CiudadController : ControllerBase
    {
        private const string connectionString = "Host=localhost;User Id=postgres;Password=654321;Database=Optativo2;";
        private CiudadService servicio;

        public CiudadController()
        {
            servicio = new CiudadService(connectionString);
        }

        [HttpGet("por-ruta/{id}")]
        public IActionResult ObtenerCiudadAccion([FromRoute] int id)
        {
            var ciudad = servicio.obtenerCiudad(id);
            return Ok(ciudad);
        }

        [HttpGet("por-parametro")]
        public IActionResult ObtenerCiudadAccion2([FromQuery] int id)
        {
            var ciudad = servicio.obtenerCiudad(id);
            return Ok(ciudad);
        }

        [HttpPost]
        public IActionResult InsertarCiudadAccion([FromBody] Infraestructura.Modelos.CiudadModel ciudad)
        {
            servicio.insertarCiudad(ciudad);
            return Created("Se creo con exito!!", ciudad);
        }

        [HttpPut]
        public IActionResult ModificarCiudadAccion([FromBody] Infraestructura.Modelos.CiudadModel ciudad)
        {
            servicio.modificarCiudad(ciudad);
            return Ok("Se actualizo con exito!!");
        }
    }
}