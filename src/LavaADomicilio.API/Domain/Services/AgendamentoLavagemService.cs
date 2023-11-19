using LavaADomicilio.API.Api.Models;
using LavaADomicilio.API.Domain.Persistence;

namespace LavaADomicilio.API.Domain.Entities
{
    public class AgendamentoLavagemService
    {
        private readonly AgendamentoLavagemDbContext _context;

        public AgendamentoLavagemService(AgendamentoLavagemDbContext context)
        {
            _context = context;
        }

        public AgendamentoLavagem FindById(Guid id)
        {
            return  _context.AgendamentoLavagems.SingleOrDefault(d => d.Id == id);
        }

        public AgendamentoLavagem FindByData(DateTime data)
        {
            return _context.AgendamentoLavagems.SingleOrDefault(d => d.Data == data && d.IsDeleted == false);
        }

        public List<AgendamentoLavagem> FindAll() 
        { 
            return _context.AgendamentoLavagems.Where(d => !d.IsDeleted).ToList(); 
        }

        public void Create(AgendamentoLavagem agendamentoLavagem)
        {
            _context.AgendamentoLavagems.Add(agendamentoLavagem);
            _context.SaveChanges();
        }

        public void Update(AgendamentoLavagem agendamentoLavagem)
        {
            _context.AgendamentoLavagems.Update(agendamentoLavagem);
            _context.SaveChanges();
        }

        public void Delete(AgendamentoLavagem agendamentoLavagem)
        {
            agendamentoLavagem.Delete();
            _context.SaveChanges();
        }
    }
}
