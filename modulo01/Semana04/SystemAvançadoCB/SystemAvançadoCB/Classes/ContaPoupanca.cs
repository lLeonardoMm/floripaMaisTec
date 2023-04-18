using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAvançadoCB.Classes
{
    public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoEnumTipoPessoa.Fisica)
            {
                throw new ArgumentException("Cliente precisa ser do tipo pessoa física");
            }
        }

        public override void Transferir(ContaBancaria conta, decimal valor)
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
            valor += 0.05M;
            Saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"O valor de R${valor} foi transferido com sucesso");
        }

        public override void Sacar(decimal valor)
        {
            if (valor > 0 & valor <= Saldo)
            {
                valor += 0.10M;
                Saldo -= valor;
            }
            else { Console.WriteLine($"Saldo insuficiente ou valor incorreto"); return; }
        }
    }
}
