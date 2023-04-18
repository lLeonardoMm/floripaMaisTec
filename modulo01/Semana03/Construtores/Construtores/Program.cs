using Construtores;

namespace Program;

    public class Program
{
    static void Main ()
    {
         Produto produto1 = new("Leite", 10.00, 5);
         Produto produto2 = new();
         Console.WriteLine($"O primeiro produto é o: {produto1.nome}, preço é {produto1.preco} e a quantidade foi {produto1.quantidade}");
         Console.WriteLine($"O segundo produto é o: {produto2.nome}, preço é {produto2.preco} e a quantidade foi {produto2.quantidade}");
    }
 
}

