using LavaADomicilio.API.Api.Models;
using LavaADomicilio.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LavaADomicilio.API.Api.Controllers
{
    [Route("api/tipo-de-lavagem")]
    [ApiController]
    public class TipoDeLavagemController : ControllerBase
    {

        private readonly TipoDeLavagemService _service;

        public TipoDeLavagemController(TipoDeLavagemService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var tiposDeLavagem = _service.FindAll();

            return Ok(tiposDeLavagem);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var tipoDeLavagem = _service.FindById(id);

            if (tipoDeLavagem == null)
            {
                return NotFound();
            }

            return Ok(tipoDeLavagem);
        }

        [HttpPost]
        public IActionResult Create(TipoDeLavagemInput input)
        {

            TipoDeLavagem tipoDeLavagem = new()
            {
                Nome = input.Nome
            };

            _service.Create(tipoDeLavagem);

            return CreatedAtAction(nameof(GetById), new { id = tipoDeLavagem.Id }, tipoDeLavagem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, TipoDeLavagemInput input)
        {
            var tipoDeLavagem = _service.FindById(id);

            if (tipoDeLavagem == null)
            {
                return NotFound();
            }

            tipoDeLavagem.Update(input);

            _service.Update(tipoDeLavagem);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var tipoDeLavagem = _service.FindById(id);

            if (tipoDeLavagem == null)
            {
                return NotFound();
            }

            _service.Delete(tipoDeLavagem);

            return NoContent();
        }

    }
}
