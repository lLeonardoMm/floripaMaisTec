
using SistemaContaBancoBanco;
using SistemaContaBancoBanco.CLasse;

ContaDoBanco conta1 = new ContaDoBanco(1234, 4321, "Leonardo", TipoEnumConta.POUPANÇA);
ContaDoBanco conta2 = new ContaDoBanco(6789, 9876, "Leonardo", TipoEnumConta.POUPANÇA);

conta1.deposito(1000);

conta1.Transferir(conta2, 300);

conta1.ExibirsaldoAtual();
conta2.ExibirsaldoAtual();