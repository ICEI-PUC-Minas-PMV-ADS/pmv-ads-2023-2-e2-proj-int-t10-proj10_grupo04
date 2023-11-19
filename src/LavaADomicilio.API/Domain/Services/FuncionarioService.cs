using LavaADomicilio.API.Domain.Persistence;

namespace LavaADomicilio.API.Domain.Entities
{
    public class FuncionarioService
    {
        private readonly FuncionarioDbContext _context;

        public FuncionarioService(FuncionarioDbContext context)
        {
            _context = context;
        }

        public Funcionario FindById(Guid id)
        {
            return  _context.Funcionarios.SingleOrDefault(d => d.Id == id);
        }

        public List<Funcionario> FindAll() { return _context.Funcionarios.Where(d => !d.IsDeleted).ToList(); }

        public void Create(Funcionario funcionario)
        {
            _context.Funcionarios.Add(funcionario);
            _context.SaveChanges();
        }

        public void Update(Funcionario funcionario)
        {
            _context.Funcionarios.Update(funcionario);
            _context.SaveChanges();
        }

        public void Delete(Funcionario funcionario)
        {
            funcionario.Delete();
            _context.SaveChanges();
        }
    }
}
