using LavaADomicilio.API.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace LavaADomicilio.API.Domain.Persistence
{
    public class TipoDeLavagemDbContext : DbContext
    {
        public TipoDeLavagemDbContext(DbContextOptions<TipoDeLavagemDbContext> options) : base(options)
        {

        }

        public DbSet<TipoDeLavagem> TiposDeLavagem { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<TipoDeLavagem>(entity =>
            {
                entity.HasKey(tipoDeLavagem => tipoDeLavagem.Id);

                entity.Property(tipoDeLavagem => tipoDeLavagem.Nome).IsRequired();
            });
        }



    }
}
