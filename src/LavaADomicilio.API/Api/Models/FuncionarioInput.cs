using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace LavaADomicilio.API.Api.Models
{
    public class FuncionarioInput
    {
        [Required]
        public string Nome { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Cpf {get; set; }
        [Required]
        public string Telefone { get; set; }

    }
}
