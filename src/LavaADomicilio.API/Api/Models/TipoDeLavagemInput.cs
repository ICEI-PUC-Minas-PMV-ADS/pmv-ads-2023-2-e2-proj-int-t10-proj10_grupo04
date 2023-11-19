using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace LavaADomicilio.API.Api.Models
{
    public class TipoDeLavagemInput
    {
        [Required]
        public string Nome { get; set; }

    }
}
