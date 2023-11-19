using LavaADomicilio.API.Api.Models;
using LavaADomicilio.API.Domain.Entities;
using LavaADomicilio.API.Domain.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LavaADomicilio.API.Api.Controllers
{
    [Route("api/agendamento-lavagem")]
    [ApiController]
    public class AgendamentoLavagemController : ControllerBase
    {
        private readonly AgendamentoLavagemService _service;

        public AgendamentoLavagemController(AgendamentoLavagemService service)
        {
            _service = service;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var agendamentoLavagens = _service.FindAll();

            return Ok(agendamentoLavagens);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var agendamentoLavagem = _service.FindById(id);

            if (agendamentoLavagem == null)
            {
                return NotFound();
            }

            return Ok(agendamentoLavagem);
        }

        [HttpPost]
        public IActionResult Create(AgendamentoLavagem agendamentoLavagem)
        {
            var agendamentoLavagemData = _service.FindByData(agendamentoLavagem.Data);

            if (agendamentoLavagemData != null)
            {
                return BadRequest("Data indisponível no momento");
            }

            _service.Create(agendamentoLavagem);

            return CreatedAtAction(nameof(GetById), new { id = agendamentoLavagem.Id }, agendamentoLavagem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, AgendamentoLavagemInput input)
        {
            var agendamentoLavagem = _service.FindById(id);

            if (agendamentoLavagem == null)
            {
                return NotFound();
            }

            var agendamentoLavagemData = _service.FindByData(input.Data);

            if (agendamentoLavagemData != null)
            {
                return BadRequest("Data indisponível no momento");
            }

            agendamentoLavagem.Update(input);

            _service.Update(agendamentoLavagem);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var agendamentoLavagem = _service.FindById(id);

            if (agendamentoLavagem == null)
            {
                return NotFound();
            }

            _service.Delete(agendamentoLavagem);

            return NoContent();
        }

    }
}
