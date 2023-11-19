using LavaADomicilio.API.Api.Models;
using LavaADomicilio.API.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace LavaADomicilio.API.Api.Controllers
{
    [Route("api/usuario")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private readonly UsuarioService _service;

        public UsuarioController(UsuarioService service)
        {
            _service = service;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginInput input)
        {

            var user = _service.FindByEmailAndSenha(input.Email, input.Senha);

            if (user != null)
            {
                // Redireciona com base no tipo de usuário
                if (user.TipoUsuario == "admin")
                {
                    return Ok(new { RedirectUrl = "/admin-dashboard" });
                }
                else if (user.TipoUsuario == "cliente")
                {
                    return Ok(new { RedirectUrl = "/home" });
                }
            }

            return BadRequest(new { Message = "Dados inválidos." });
        }


        [HttpGet]
        public IActionResult GetAll()
        {
            var usuarios = _service.FindAll();

            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var usuario = _service.FindById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        [HttpPost]
        public IActionResult Create(UsuarioInput input)
        {
            if (input.Senha != input.ConfirmacaoSenha)
            {
                return BadRequest("Senha e confirmação de senha devem ser iguais");
            }

            var usuarioData = _service.FindByEmail(input.Email);

            if (usuarioData != null)
            {
                return BadRequest("Email já esta sendo utilizado");
            }

            Usuario usuario = new()
            {
                Nome = input.Nome,
                Email = input.Email,
                Senha = input.Senha,
                TipoUsuario = "cliente"
            };

            _service.Create(usuario);

            return CreatedAtAction(nameof(GetById), new { id = usuario.Id }, usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, UsuarioInput input)
        {
            var usuario = _service.FindById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            var usuarioEmail = _service.FindByEmail(input.Email);

            if (usuarioEmail != null)
            {
                return BadRequest("Email já esta sendo utilizado");
            }

            usuario.Update(input);

            _service.Update(usuario);

            return NoContent();
        }

        [HttpPut("{id}/mudar-senha")]
        public IActionResult UpdatePassword(Guid id, UsuarioChangePasswordInput input)
        {
            var usuario = _service.FindById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            if (input.Senha != input.ConfirmacaoSenha)
            {
                return BadRequest("Senha e confirmação de senha devem ser iguais");
            }

            usuario.UpdatePassword(input);

            _service.Update(usuario);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var usuario = _service.FindById(id);

            if (usuario == null)
            {
                return NotFound();
            }

            _service.Delete(usuario);

            return NoContent();
        }

    }
}
