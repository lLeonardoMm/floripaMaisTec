string[] nomeDosAlunos = new string[5];
int[] mediaFinal = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite o nome da/o {i + 1}º aluna/o: ");
    nomeDosAlunos[i] = Console.ReadLine();
}
Console.WriteLine("\n----------------\n");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Digite a nota da/o aluna/o {nomeDosAlunos[i]}: ");
    mediaFinal[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("\n----------------\n");
for (int i = 0; i < 5; i++)
{
    if (mediaFinal[i] >= 6)
    {
        Console.WriteLine($"A(O) aluna(o) {nomeDosAlunos[i]} foi APROVADA(O).\n-------");
    }
    else
    {
        Console.WriteLine($"A(o) aluna(o) {nomeDosAlunos[i]} foi REPROVADA(O).\n-------");
    }
}