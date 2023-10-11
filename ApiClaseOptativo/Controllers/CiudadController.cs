using Microsoft.AspNetCore.Mvc;

namespace OptativoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CiudadController : ControllerBase
    {
        private const string connectionString = "Host=localhost;User Id=postgres;Password=654321;Database=Optativo2;";
        //private CiudadService

        public CiudadController()
        {
        }

        [HttpGet]
        public IActionResult ObtenerCiudadAccion()
        {
            //CiudadService

            return Ok("Este es un texto de prueba");
        }
    }
}