Console.WriteLine("Olá, você está no aplicativo de frutas. Por favor escolha até 15 frutras.\nE Se quiser parar em algum momento digite [Parar]\n");

List<string> frutas = new List<string>();

bool proximo = true;
while (proximo)
{
    if (frutas.Count() == 15)
    {
        proximo = false;
    }

    Console.WriteLine("Qual vai ser a fruta?");
    frutas.Add(Console.ReadLine());

    string parar = frutas.Last(); //usei o .Last pois assim não fica repetindo a mesma frase para continuar ou não e assim fica mais leve.
    if (parar == "Parar" || parar == "parar")
    {
        proximo = false;
    }
    Console.WriteLine("");
}
frutas.Remove("Parar"); //Remove pois Parar e parar estavam entrando na lista
frutas.Remove("parar");
Console.WriteLine("As frutas escolhidas foras as seguintes:");
frutas.Sort();
foreach (string listaDasFrutas in frutas)
{
    Console.WriteLine(listaDasFrutas);
}