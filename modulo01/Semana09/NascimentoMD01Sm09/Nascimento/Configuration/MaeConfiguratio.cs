using bercario.Models;
using Microsoft.EntityFrameworkCore;

namespace bercario.Configuration
{
    public class MaeConfiguratio : IEntityTypeConfiguration<Mae>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Mae> builder)
        {
            builder.ToTable("Mae");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Nome).HasMaxLength(60);
            builder.Property(e => e.Endereco).HasMaxLength(300);
            builder.Property(e => e.Telefone).HasMaxLength(20);
        }
    }
}
