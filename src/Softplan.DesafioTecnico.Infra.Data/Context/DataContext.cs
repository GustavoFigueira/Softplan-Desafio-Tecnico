using Microsoft.EntityFrameworkCore;
using Softplan.DesafioTecnico.Domain.Entities;

namespace Softplan.DesafioTecnico.Infra.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Juros Compostos
        public DbSet<CompoundInterest> CompoundInterest { get; set; }
        // Taxa de Juros
        public DbSet<InterestRate> InterestRate { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
