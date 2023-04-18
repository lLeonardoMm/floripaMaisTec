namespace ConsoleApp
{
    internal class ProdutoFinanceiro : Produto
    {
        public void Acesso(string nome, string cor) 
        {
            ProdutoFinanceiro produto = new();
            produto.nome = nome;
            produto.cor = cor;
            Console.WriteLine($"Nome {produto.nome} e cor {produto.cor}");
            produto.Vender();
            produto.VerificarEstoque();
            produto.AlterarAtributosPrivados(99, 100.0);
        }
    }
}
