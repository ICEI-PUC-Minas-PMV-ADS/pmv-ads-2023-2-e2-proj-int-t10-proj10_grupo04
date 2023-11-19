using LavaADomicilio.API.Api.Models;
using LavaADomicilio.API.Domain.Persistence;

namespace LavaADomicilio.API.Domain.Entities
{
    public class TipoDeLavagemService
    {
        private readonly TipoDeLavagemDbContext _context;

        public TipoDeLavagemService(TipoDeLavagemDbContext context)
        {
            _context = context;
        }

        public TipoDeLavagem FindById(Guid id)
        {
            return  _context.TiposDeLavagem.SingleOrDefault(d => d.Id == id);
        }

        public TipoDeLavagem FindByNome(string nome)
        {
            return _context.TiposDeLavagem.SingleOrDefault(d => d.Nome == nome && d.IsDeleted == false);
        }

        public List<TipoDeLavagem> FindAll() { return _context.TiposDeLavagem.Where(d => !d.IsDeleted).ToList(); }

        public void Create(TipoDeLavagem tipoDeLavagem)
        {
            _context.TiposDeLavagem.Add(tipoDeLavagem);
            _context.SaveChanges();
        }

        public void Update(TipoDeLavagem tipoDeLavagem)
        {
            _context.TiposDeLavagem.Update(tipoDeLavagem);
            _context.SaveChanges();
        }

        public void Delete(TipoDeLavagem tipoDeLavagem)
        {
            tipoDeLavagem.Delete();
            _context.SaveChanges();
        }
    }
}
