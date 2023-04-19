using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace M01Semana09.Aula01.Modelos.Configurations
{
    public class ProdutoPromocoesConfigurations : IEntityTypeConfiguration<PromocaoProduto>
    {
        public void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            builder.HasOne(x => x.ProdutoId).WithMany(x => x.ProdutosPromoces).HasForeignKey(x => x.ProdutoId).HasConstraintName("FK_Id_Produto");
            builder.HasOne(x => x.PromocaoId).WithMany(x => x.PromocoesProdutos).HasForeignKey(x => x.PromocaoId).HasConstraintName("FK_Id_Promocao");
        }
    }
}
