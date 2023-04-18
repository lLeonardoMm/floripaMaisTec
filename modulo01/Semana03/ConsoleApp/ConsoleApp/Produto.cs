namespace ConsoleApp
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double _preco;
        private double _peso;

        public void VerificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }
        protected void Vender()
        {
            Console.WriteLine("endendo produto, acessando método vender da classe produto");
        }
        private void Descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }
        protected void AlterarAtributosPrivados(double peso2, double preco)
        {
            _peso = peso2;
            Console.WriteLine($"Variável peso de escopo da classe: {_peso}");
        }
    }
}
