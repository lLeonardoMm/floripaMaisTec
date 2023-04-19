using bercario.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace bercario.Configuration
{
    public class BebeConfiguratio : IEntityTypeConfiguration<Bebe>
    {
        public void Configure(EntityTypeBuilder<Bebe> builder)
        {
            builder.ToTable("Bebe");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.PesoDeNascimento).HasPrecision(4, 3);
            builder.HasOne(b => b.MaeBebe).WithMany(m => m.Bebes).HasForeignKey(b => b.IdDeMae).HasConstraintName("FK_Bebe_Mae");
            builder.HasOne(b => b.PartoBebe).WithMany(m => m.Bebes).HasForeignKey(b => b.IdDoParto).HasConstraintName("FK_Bebe_Parto");
        }
    }
}
