using M01Semana09.Aula01.Modelos;
using M01Semana09.Aula01.Modelos.Configurations;
using Microsoft.EntityFrameworkCore;

namespace M01Semana09.Aula01.LojaContexto
{
    public class LojaContexto : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promacoes { get; set; }
        public DbSet<PromocaoProduto> PromocaosProdutosFK { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CompraConfigurations());
            modelBuilder.ApplyConfiguration(new ProdutoPromocoesConfigurations());
            modelBuilder.ApplyConfiguration(new ClienteConfigurations());
        }
    }
}
