using LavaADomicilio.API.Api.Models;
using LavaADomicilio.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LavaADomicilio.API.Api.Controllers
{
    [Route("api/funcionario")]
    [ApiController]
    public class FuncionarioController : ControllerBase
    {

        private readonly FuncionarioService _service;

        public FuncionarioController(FuncionarioService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var funcionarios = _service.FindAll();

            return Ok(funcionarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var funcionario = _service.FindById(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            return Ok(funcionario);
        }

        [HttpPost]
        public IActionResult Create(FuncionarioInput input)
        {

            Funcionario funcionario = new()
            {
                Nome = input.Nome,
                Email = input.Email,
                Cpf = input.Cpf,
                Telefone = input.Telefone
            };

            _service.Create(funcionario);

            return CreatedAtAction(nameof(GetById), new { id = funcionario.Id }, funcionario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, FuncionarioInput input)
        {
            var funcionario = _service.FindById(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            funcionario.Update(input);

            _service.Update(funcionario);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var funcionario = _service.FindById(id);

            if (funcionario == null)
            {
                return NotFound();
            }

            _service.Delete(funcionario);

            return NoContent();
        }

    }
}
