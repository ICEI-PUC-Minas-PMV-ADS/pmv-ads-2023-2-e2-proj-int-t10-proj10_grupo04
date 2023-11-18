using LavaADomicilio.API.Api.Models;

namespace LavaADomicilio.API.Domain.Entities
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string TipoUsuario { get; set; } // Pode ser "admin" ou "cliente"
        public bool IsDeleted { get; set; }

        public void UpdatePassword(UsuarioChangePasswordInput input)
        {
            Senha = input.Senha;
        }

        public void Update(UsuarioInput input)
        {
            Nome = input.Nome;
            Email = input.Email;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
