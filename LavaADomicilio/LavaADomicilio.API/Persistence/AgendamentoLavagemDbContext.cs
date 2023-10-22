using LavaADomicilio.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace LavaADomicilio.API.Persistence
{
    public class AgendamentoLavagemDbContext :  DbContext
    {
        public AgendamentoLavagemDbContext(DbContextOptions<AgendamentoLavagemDbContext> options) : base(options)
        {
            
        }

        public DbSet<AgendamentoLavagem> AgendamentoLavagems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<AgendamentoLavagem>(entity =>
            {
                entity.HasKey(agendamentoLavagem => agendamentoLavagem.Id);

                entity.Property(agendamentoLavagem => agendamentoLavagem.Nome).IsRequired();
            });
        }



    }
}
