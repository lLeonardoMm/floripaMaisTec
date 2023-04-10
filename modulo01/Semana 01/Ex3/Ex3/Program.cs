List<int> numerosPares = new List<int>();
List<int> numerosImpares = new List<int>();

for (int i = 0; i < 10; i++)
{
    Console.Write($"Digite o {i + 1} número: ");
    int num = int.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        numerosPares.Add(num);
    }
    else
    {
        numerosImpares.Add(num);
    }
}
numerosImpares.Sort();
numerosPares.Sort();

Console.WriteLine($"\nA lista de números pares possui {numerosPares.Count()} números e a soma deles é igual a {numerosPares.Sum()}.");
Console.WriteLine($"E a lista de números ímpares possui {numerosImpares.Count()} números e a soma deles é igual a {numerosImpares.Sum()}");