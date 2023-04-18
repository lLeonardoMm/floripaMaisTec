decimal numero1;
decimal numero2;

try
{
    Console.Write("Descreva primeiro numero: ");
    numero1 = Convert.ToDecimal(Console.ReadLine());

    Console.Write("Descreva segundo numero: ");
    numero2 = Convert.ToDecimal(Console.ReadLine());
    if (numero1 % numero2 == 0)
    {
        Console.WriteLine($"Deu certo {numero1 / numero2}");
    }
}
catch (DivideByZeroException divisãoPorZeroEx)
{
    Console.WriteLine($"Não é possivel dividir por zero: {divisãoPorZeroEx.Message}");
}
catch (FormatException letraDigitadaEx)
{
    Console.WriteLine($"Letras não podem ser informada: {letraDigitadaEx.Message}");
}
catch (Exception ex)
{
    Console.WriteLine($"Ocorreu um erro: {ex.Message}");
}
finally
{
    numero1 = 0;
    numero2 = 0;
    Console.WriteLine("Encerrando o programa");
}