using LavaADomicilio.API.Api.Models;

namespace LavaADomicilio.API.Domain.Entities
{
    public class TipoDeLavagem
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public bool IsDeleted { get; set; }

        public void Update(TipoDeLavagemInput input)
        {
            Nome = input.Nome;
        }

        public void Delete()
        {
            IsDeleted = true;
        }

    }
}
