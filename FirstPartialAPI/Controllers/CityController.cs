using Infraestructure.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace FirstPartialAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // This is the route
    public class CityController : Controller
    {
        // TODO: change all the metods
        private CityService CityService;
        private IConfiguration configuration;

        /*public CityController()*/
        public CityController(IConfiguration configuration)
        {
            this.configuration = configuration;
            this.CityService = new CityService(configuration.GetConnectionString("postgresDB"));
        }

        [HttpGet("ListarCiudades")]
        public ActionResult<List<CityModel>> read()
        {
            var resultado = CityService.read();
            return Ok(resultado);
        }

        [HttpGet("ConsultarCiudad/{id}")]
        /*public ActionResult<CityModel> getById(int id, string documento)*/
        public ActionResult<CityModel> getById(int id)
        {
            var result = this.CityService.getByid(id);
            return Ok(result);
        }

        [HttpPost("InsertarCiudad")]
        public ActionResult<string> insert(CityModel models)
        {
            /*return Ok("Ok");*/
            var result = this.CityService.insert(new Infraestructure.Models.CityModel
            {
                State = models.State,
                City = models.City,
                
            });
            return Ok(result);
        }
        // endpoint for subject modify
        [HttpPut("ModificarCiudad/{id}")]
        public ActionResult<string> modify(CityModel models, int id)
        {
            var result = this.CityService.modify(new Infraestructure.Models.CityModel
            {
                State = models.State,
                City = models.City,
            }, id);
            return Ok(result);
        }

        // endpoint for subject delete
        [HttpDelete("EliminarCiudad/{id}")]
        public ActionResult<string> delete(int id)
        {
            var result = this.CityService.delete(id);
            return Ok(result);
        }

    }
}
