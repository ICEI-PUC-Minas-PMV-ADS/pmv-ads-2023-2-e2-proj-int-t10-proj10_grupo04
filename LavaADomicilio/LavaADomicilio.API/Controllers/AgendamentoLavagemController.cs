using LavaADomicilio.API.Entities;
using LavaADomicilio.API.Models;
using LavaADomicilio.API.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LavaADomicilio.API.Controllers
{
    [Route("api/agendamento-lavagem")]
    [ApiController]
    public class AgendamentoLavagemController : ControllerBase
    {
        private readonly AgendamentoLavagemDbContext _context;

        public AgendamentoLavagemController(AgendamentoLavagemDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var agendamentoLavagens = _context.AgendamentoLavagems.Where(d => !d.IsDeleted).ToList();

            return Ok(agendamentoLavagens);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var agendamentoLavagem = _context.AgendamentoLavagems.SingleOrDefault(d => d.Id == id);

            if(agendamentoLavagem == null)
            {
                return NotFound();
            }

            return Ok(agendamentoLavagem);
        }

        [HttpPost]
        public IActionResult Create(AgendamentoLavagem agendamentoLavagem)
        {
            var agendamentoLavagemData = _context.AgendamentoLavagems.SingleOrDefault(d => d.Data == agendamentoLavagem.Data && d.IsDeleted == false);

            if (agendamentoLavagemData != null)
            {
                return BadRequest("Data indisponível no momento");
            }

            _context.AgendamentoLavagems.Add(agendamentoLavagem);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new {id= agendamentoLavagem .Id}, agendamentoLavagem);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, AgendamentoLavagemInput input)
        {
            var agendamentoLavagem = _context.AgendamentoLavagems.SingleOrDefault(d => d.Id == id);

            if (agendamentoLavagem == null)
            {
                return NotFound();
            }

            var agendamentoLavagemData = _context.AgendamentoLavagems.SingleOrDefault(d => d.Data == input.Data && d.IsDeleted == false);

            if (agendamentoLavagemData != null)
            {
                return BadRequest("Data indisponível no momento");
            }

            agendamentoLavagem.Update(input);

            _context.AgendamentoLavagems.Update(agendamentoLavagem);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var agendamentoLavagem = _context.AgendamentoLavagems.SingleOrDefault(d => d.Id == id);

            if (agendamentoLavagem == null)
            {
                return NotFound();
            }

            agendamentoLavagem.Delete();
            _context.SaveChanges();

            return NoContent();
        }

    }
}
