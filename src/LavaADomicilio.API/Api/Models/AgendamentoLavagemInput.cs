using LavaADomicilio.API.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace LavaADomicilio.API.Api.Models
{
    public class AgendamentoLavagemInput
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public TipoDeLavagem TipoDeLavagem { get; set; }
        [Required]
        public string Telefone { get; set; }
        [Required]
        public string Logradouro { get; set; }
        [Required]
        public int Numero { get; set; }
        [Required]
        public string Bairro { get; set; }
        [Required]
        public string Cidade { get; set; }
        [Required]
        public string Cep { get; set; }
        [Required]
        public string NumeroCartao { get; set; }
        [Required]
        public string DataExpiracaoCartao { get; set; }
        [Required]
        public string CvcCartao { get; set; }
        [Required]
        public string NumeroParcelasCartao { get; set; }
        [Required]
        public DateTime Data { get; set; }
    }
}
