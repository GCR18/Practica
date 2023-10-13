using Microsoft.AspNetCore.Mvc;
using Practica_taller.context;
using Practica_taller.Modelos;

namespace Practica_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class universidadController : ControllerBase
    {

        private readonly ILogger<universidadController> _logger;
        private readonly aplicacion_Context _aplicacion_Context;
        public universidadController(
            ILogger<universidadController> logger,
            aplicacion_Context aplicacion_Context)
        {
            _logger = logger;
            _aplicacion_Context = aplicacion_Context;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] universidad Universidad)
        {
            _aplicacion_Context.Universidades.Add(Universidad);
            _aplicacion_Context.SaveChanges();
            return Ok(Universidad);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacion_Context.Universidades.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] universidad Universidad)
        {
            _aplicacion_Context.Universidades.Update(Universidad);
            _aplicacion_Context.SaveChanges();
            return Ok(Universidad);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int ID_universidad)
        {
            _aplicacion_Context.Universidades.Remove(
                _aplicacion_Context.Universidades.ToList()
                .Where(x => x.id_universidad == ID_universidad)
                .FirstOrDefault());
            _aplicacion_Context.SaveChanges();
            return Ok(ID_universidad);
        }
    }
}
