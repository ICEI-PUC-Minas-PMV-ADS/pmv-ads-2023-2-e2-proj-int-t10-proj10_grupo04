using LavaADomicilio.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LavaADomicilio.API.Domain.Persistence
{
    public class FuncionarioDbContext : DbContext
    {
        public FuncionarioDbContext(DbContextOptions<FuncionarioDbContext> options) : base(options)
        {

        }

        public DbSet<Funcionario> Funcionarios { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(funcionario => funcionario.Id);

                entity.Property(funcionario => funcionario.Nome).IsRequired();
            });
        }



    }
}
