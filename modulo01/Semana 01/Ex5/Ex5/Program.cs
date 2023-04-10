Console.Write("digite o numero que será a quantidade de números calculados pela sequência de fibonacci: ");
int num = int.Parse(Console.ReadLine());


int x = 1;
int z = 0;
int y = 0;

Console.Write($"A sequencia de {num} fibonacci números são: 1, ");
for (int i = 0; i < num; i++)
{
    y = z + x;
    Console.Write($"{y}, ");
    z = x;
    x = y;
}

