using LavaADomicilio.API.Api.Models;

namespace LavaADomicilio.API.Domain.Entities
{
    public class AgendamentoLavagem
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario Funcionario { get; set; }
        public TipoDeLavagem TipoDeLavagem { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string NumeroCartao { get; set; }
        public string DataExpiracaoCartao { get; set; }
        public string CvcCartao { get; set; }
        public string NumeroParcelasCartao { get; set; }
        public DateTime Data { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(AgendamentoLavagemInput input)
        {
            Nome = input.Nome;
            Email = input.Email;
            TipoDeLavagem = input.TipoDeLavagem;
            Telefone = input.Telefone;
            Logradouro = input.Logradouro;
            Numero = input.Numero;
            Bairro = input.Bairro;
            Cidade = input.Cidade;
            Cep = input.Cep;
            NumeroCartao = input.NumeroCartao;
            DataExpiracaoCartao = input.DataExpiracaoCartao;
            CvcCartao = input.CvcCartao;
            NumeroParcelasCartao = input.NumeroParcelasCartao;
            Data = input.Data;
        }

        public void AddFuncionario(Funcionario funcionario)
        {
            Funcionario = funcionario;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

       
    }
}
