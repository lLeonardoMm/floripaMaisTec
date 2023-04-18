using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAvançadoCB.Classes
{
    public class ContaEmpresarial : ContaBancaria
    {
        public decimal LimiteEmprestimo { get; private set; }
        public decimal TaxaJuros { get; private set; }
        public bool PossuiEmprestimo { get; private set; }
        public decimal ValorUsado { get; private set; }
        public string CNPJ { get; private set; }

        public ContaEmpresarial(decimal limiteEmprestimo, decimal taxaJuros, decimal valorUsado, string cNPJ, int numero, int agencia, Cliente cliente)
            : base(numero, agencia, cliente)
        {
            LimiteEmprestimo = limiteEmprestimo;
            TaxaJuros = taxaJuros;
            ValorUsado = valorUsado;
            CNPJ = cNPJ;
            /*--------------------------\/ Verificação para que só pessoa Juridica crie Conta Empresarial \/--------------------------------*/
            if (cliente.TipoPessoa != TipoEnumTipoPessoa.Juridica)
            {
                throw new ArgumentException("Cliente precisa ser do tipo pessoa juridica");
            }
        }
        public void FazerEmprestimo(decimal valor)
        {
            if (valor > LimiteEmprestimo) 
            {
                Console.WriteLine($"O valor não pode ser maior do que {LimiteEmprestimo}"); return;
            }
            if (PossuiEmprestimo == true)
            {
                Console.WriteLine("Pague o último emprestimo"); return;
            }
            Saldo += valor;
            ValorUsado += valor;
            PossuiEmprestimo = true;
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
            valor += 0.50M;
            Saldo -= valor;
            conta.Depositar(valor);

            Console.WriteLine($"O valor de R${valor} foi transferido com sucesso");
        }

        public void PagarEmprestimo(decimal valor)
        {
            if (valor == ValorUsado + TaxaJuros) 
            {
                Console.WriteLine("O emprestimo foi pago");
                Saldo -= valor;
                PossuiEmprestimo = false;
            }
            else { Console.WriteLine("O emprestimo tem que ser pago no valor integral"); };
        }
        public override void Sacar(decimal valor)
        {
            if (valor > 0 & valor <= Saldo)
            {
                valor += 1;
                Saldo -= valor;
            }
            else { Console.WriteLine($"Saldo insuficiente ou valor incorreto"); return; }
        }
    }
}
