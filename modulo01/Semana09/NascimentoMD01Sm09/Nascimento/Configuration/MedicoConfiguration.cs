using bercario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bercario.Configuration
{
    public class MedicoConfiguratio : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.ToTable("Medico");
            builder.HasKey(x => x.Id);
            builder.Property(e => e.CRM).HasMaxLength(15);
            builder.Property(e => e.Nome).HasMaxLength(60);
            builder.Property(e => e.Especialidade).HasMaxLength(100);
        }
    }
}
