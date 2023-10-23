using Microsoft.AspNetCore.Mvc;
using Practica_taller.context;
using Practica_taller.Modelos;

namespace Practica_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class materiasController : ControllerBase
    {

        private readonly ILogger<materiasController> _logger;
        private readonly aplicacion_Context _aplicacion_Context;
        public materiasController(
            ILogger<materiasController> logger,
            aplicacion_Context aplicacion_Context)
        {
            _logger = logger;
            _aplicacion_Context = aplicacion_Context;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] materia Materia)
        {
            _aplicacion_Context.Materias.Add(Materia);
            _aplicacion_Context.SaveChanges();
            return Ok(Materia);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacion_Context.Materias.ToList());

        }
        [Route("/id")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] materia Materia)
        {
            _aplicacion_Context.Materias.Update(Materia);
            _aplicacion_Context.SaveChanges();
            return Ok(Materia);
        }
        [Route("/id")]
        [HttpDelete]
        public IActionResult Delete(int ID_materia)
        {
            _aplicacion_Context.Materias.Remove(
                _aplicacion_Context.Materias.ToList()
                .Where(x => x.id_materia == ID_materia)
                .FirstOrDefault());
            _aplicacion_Context.SaveChanges();
            return Ok(ID_materia);
        }
    }
}
