using System.Numerics;

namespace LavaADomicilio.API.Models
{
    public class AgendamentoLavagemInput
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string TipoDeLavagem { get; set; }
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
    }
}
