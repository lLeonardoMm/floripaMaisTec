using Banco;
using Banco.CLasse;

ContaDoBanco usuario = new ContaDoBanco();


Console.WriteLine("Olá tudo bem! \nPor favor digite 'deposito' se você quer depositar e 'sacar' se você quiser sacar");
string acaoDoUsuario = Console.ReadLine();

if (acaoDoUsuario == "deposito")
{
    Console.WriteLine("Por favor digite o valor que você quer depositar");
    usuario.deposito(int.Parse(Console.ReadLine()));
}
else if (acaoDoUsuario == "sacar")
{
    Console.WriteLine("Por favor digite o valor que você quer sacar");
    usuario.saque(int.Parse(Console.ReadLine()));
}
else
{
    Console.WriteLine("Desculpe, você digitou errado");
}


