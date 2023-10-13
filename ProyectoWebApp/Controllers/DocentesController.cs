using Microsoft.AspNetCore.Mvc;
using ProyectoWebApp.Context;
using ProyectoWebApp.Models;

namespace ProyectoWebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocentesController : ControllerBase
    {

        private readonly ILogger<DocentesController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;
        public DocentesController(
            ILogger<DocentesController> logger,
            AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        //Create: Crear docentes
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Docente docente)
        {
            _aplicacionContexto.Docente.Add(docente);
            _aplicacionContexto.SaveChanges();
            return Ok(docente);
        }
        //READ: Obtener lista de docentes
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacionContexto.Docente.ToList());

        }
        //Update: Modificar docentes
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Docente docente)
        {
            _aplicacionContexto.Docente.Update(docente);
            _aplicacionContexto.SaveChanges();
            return Ok(docente);
        }
        //Delete: Eliminar docentes
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int docenteId)
        {
            _aplicacionContexto.Docente.Remove(
                _aplicacionContexto.Docente.ToList()
                .Where(x => x.idDocente == docenteId)
                .FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(docenteId);
        }
    }
}
