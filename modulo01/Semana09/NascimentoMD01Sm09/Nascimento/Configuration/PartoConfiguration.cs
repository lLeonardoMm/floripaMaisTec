using bercario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bercario.Configuration
{
    public class PartoConfiguratio : IEntityTypeConfiguration<Parto>
    {
        public void Configure(EntityTypeBuilder<Parto> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(m => m.MedicoParto).WithMany(p => p.Partos).HasForeignKey(m => m.IdDoMedico).HasConstraintName("FK_Parto_Medico");
        }
    }
}
