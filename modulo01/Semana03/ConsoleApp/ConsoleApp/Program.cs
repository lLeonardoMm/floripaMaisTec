using ConsoleApp;

Produto produto1 = new Produto();
ProdutoFinanceiro classeFilha = new ProdutoFinanceiro();

produto1.nome = "Calculadora";
produto1.VerificarEstoque();
Console.WriteLine($"O nome do produto é: {produto1.nome}");

classeFilha.nome = "Barril";
classeFilha.VerificarEstoque();
classeFilha.Acesso("teste", "branco");