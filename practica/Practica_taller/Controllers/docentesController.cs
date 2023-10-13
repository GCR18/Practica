using Microsoft.AspNetCore.Mvc;
using Practica_taller.context;
using Practica_taller.Modelos;

namespace Practica_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class docentesController : ControllerBase
    {

        private readonly ILogger<docentesController> _logger;
        private readonly aplicacion_Context _aplicacion_Context;
        public docentesController(
            ILogger<docentesController> logger,
            aplicacion_Context aplicacion_Context)
        {
            _logger = logger;
            _aplicacion_Context = aplicacion_Context;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] docente Docente)
        {
            _aplicacion_Context.Docentes.Add(Docente);
            _aplicacion_Context.SaveChanges();
            return Ok(Docente);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacion_Context.Docentes.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] docente Docente)
        {
            _aplicacion_Context.Docentes.Update(Docente);
            _aplicacion_Context.SaveChanges();
            return Ok(Docente);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int ID_docente)
        {
            _aplicacion_Context.Docentes.Remove(
                _aplicacion_Context.Docentes.ToList()
                .Where(x => x.id_docente == ID_docente)
                .FirstOrDefault());
            _aplicacion_Context.SaveChanges();
            return Ok(ID_docente);
        }
    }
}
