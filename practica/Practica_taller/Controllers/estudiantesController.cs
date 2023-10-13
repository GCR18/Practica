using Microsoft.AspNetCore.Mvc;
using Practica_taller.context;
using Practica_taller.Modelos;

namespace Practica_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class estudiantesController : ControllerBase
    {

        private readonly ILogger<estudiantesController> _logger;
        private readonly aplicacion_Context _aplicacion_Context;
        public estudiantesController(
            ILogger<estudiantesController> logger,
            aplicacion_Context aplicacion_Context)
        {
            _logger = logger;
            _aplicacion_Context = aplicacion_Context;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] estudiante Estudiante)
        {
            _aplicacion_Context.Estudiantes.Add(Estudiante);
            _aplicacion_Context.SaveChanges();
            return Ok(Estudiante);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacion_Context.Estudiantes.ToList());

        }
        [Route("/id")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] estudiante Estudiante)
        {
            _aplicacion_Context.Estudiantes.Update(Estudiante);
            _aplicacion_Context.SaveChanges();
            return Ok(Estudiante);
        }
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int ID_estudiante)
        {
            _aplicacion_Context.Estudiantes.Remove(
                _aplicacion_Context.Estudiantes.ToList()
                .Where(x => x.id_estudiante == ID_estudiante)
                .FirstOrDefault());
            _aplicacion_Context.SaveChanges();
            return Ok(ID_estudiante);
        }
    }
}
