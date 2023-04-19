using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01Semana09.Aula01.Modelos.Configurations
{
    public class ClienteConfigurations : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasOne(x => x.EnderecoId).WithOne(x=> x.Clientes).HasForeignKey<Cliente>(x => x.Id).HasConstraintName("Fk_Cliente_Endereco");
        }
    }
}
