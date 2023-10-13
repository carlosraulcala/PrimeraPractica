using Microsoft.AspNetCore.Mvc;
using ProyectoWebApp.Context;
using ProyectoWebApp.Models;

namespace ProyectoWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UniversidadesController : ControllerBase
    {

        private readonly ILogger<UniversidadesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public UniversidadesController(
            ILogger<UniversidadesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear universidades
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Universidad universidad)
        {
            _aplicacionContexto.Universidad.Add(universidad);
            _aplicacionContexto.SaveChanges();
            return Ok(universidad);
        }
        //READ: Obtener lista de universidades
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Universidad.ToList());

        }
        //Update: Modificar universidades
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Universidad universidad)
        {
            _aplicacionContexto.Universidad.Update(universidad);
            _aplicacionContexto.SaveChanges();
            return Ok(universidad);
        }
        //Delete: Eliminar universidades
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int universidadId)
        {
            _aplicacionContexto.Universidad.Remove(
                _aplicacionContexto.Universidad.ToList()
                .Where(x => x.idUniversidad == universidadId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(universidadId);
        }
    }
}
