namespace SystemAvançadoCB.Classes
{
    public class ContaBancaria
        {
        public int Numero {get;protected set;}
        public int Agencia { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public decimal Saldo { get; protected set; } = 0;

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
        }

        /*------------------------------Contrutores---------------------------------------------------------------*/
        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor tem que se maior que 0");
                return;
            }
            if (Saldo < valor)
            {
                Console.WriteLine("Seu saldo é menor que o valor da transferencia");
                return;
            }
            Saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"O valor de R${valor} foi transferido com sucesso");
        }

        public virtual void Depositar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
            else { Console.WriteLine("Valor não permitido"); return; }
        }
        public virtual void Sacar(decimal valor)
        {
            if (valor > 0 & valor <= Saldo)
            {
                Saldo -= valor;
            }
            else { Console.WriteLine($"Saldo insuficiente ou valor incorreto"); return; }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual é de {Saldo}");
        }
    }
}

