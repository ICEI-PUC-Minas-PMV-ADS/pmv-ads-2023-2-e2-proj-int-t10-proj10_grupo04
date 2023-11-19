using LavaADomicilio.API.Api.Models;

namespace LavaADomicilio.API.Domain.Entities
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(FuncionarioInput input)
        {
            Nome = input.Nome;
            Cpf = input.Cpf;
            Email = input.Email;
            Telefone = input.Telefone;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
