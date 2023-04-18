using SistemaContaBancoBanco.CLasse;

namespace SistemaContaBancoBanco
{
    public class ContaDoBanco
    {
        private int _numero;
        private int _agencia;
        private string _nomeDoTitular;
        private decimal _saldo = 0;
        private TipoEnumConta _conta;

        public ContaDoBanco(int numero, int agencia, string nomeDoTitular, TipoEnumConta conta)
        {
            _numero = numero;
            _agencia = agencia;
            _nomeDoTitular = nomeDoTitular;
            _conta = conta;
        }

        public ContaDoBanco(string nomeDoTitular, TipoEnumConta conta)
        {
            _nomeDoTitular = nomeDoTitular;
            _conta = conta;
            Random random = new Random();
            _numero = random.Next(0000, 9999);
            _agencia = random.Next(0000, 9999);
        }

        public void Transferir(ContaDoBanco conta, decimal valor)
        {
            if (valor <= 0) 
            {
                Console.WriteLine("O valor tem que se maior que 0");
                return;
            }
            if (_saldo < valor)
            {
                Console.WriteLine("Seu saldo é menor que o valor da transferencia");
                return;
            }
            _saldo -= valor;
            conta.deposito(valor);

            Console.WriteLine($"O valor de R${valor}, foi transferido com sucesso");
        }

        public void deposito(decimal valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
            else { Console.WriteLine("Não foi depositado, ou valor não permitido"); return; }
        }
        public void saque(int valor)
        {
            if (valor > 0 & valor <= _saldo)
            {
                _saldo -= valor;
            }
            else { Console.WriteLine($"Saldo insuficiente ou valor incorreto"); return; }
        }

        public void ExibirsaldoAtual()
        {
            Console.WriteLine($"O saldo atual é de {_saldo}");
        }
    }
}