using Banco.CLasse;

namespace Banco
{
     public class ContaDoBanco
    {
        public int numero;
        public int agencia;
        public string nomeDoTitular;
        public decimal saldo = 0;
        public TipoContaEnum conta;

        public void deposito(int valor)
        {
            if (valor > 0)
            { 
                saldo = saldo + valor;
                saldoAtual();
            }
            else { Console.WriteLine("Não foi depositado, ou valor não permitido"); }
        } 
        public void saque(int valor) 
        {
            if (valor > 0 & valor <= saldo)
            {
                saldo = saldo - valor;
                saldoAtual();
            }
            else { Console.WriteLine($"Saldo insuficiente ou valor incorreto"); }
        }

        public void saldoAtual() 
        {
            Console.WriteLine($"O saldo atual é de {saldo}");
        }
    }
}
