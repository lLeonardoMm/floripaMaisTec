int[] numeros = new int[5];
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Digite o {1 + i} número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}
Console.Write("----------------------\n");
for (int i = 0; i < numeros.Length; i++)
{
    int contador = 1;

    for (int j = 1; j < numeros[i]; j++)
    {
        if (numeros[i] % j == 0)
        {
            contador++;
        }
    }
    if (contador == 2)
    {
        Console.WriteLine($"O número {numeros[i]} é um número primo, e está na posição {1 + i}");
    }
    else
    {
        Console.WriteLine($"{numeros[i]} não é um número primo ");
    }
}