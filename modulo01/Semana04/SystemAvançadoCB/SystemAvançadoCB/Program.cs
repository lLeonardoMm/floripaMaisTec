using SystemAvançadoCB.Classes;


Cliente pessoa1 = new Cliente("Leonardo", "Dev", TiposEnumEstadoCivil.Solteiro, TipoEnumTipoPessoa.Juridica,DateTime.Parse("2003-12-12"));
Cliente pessoa2 = new Cliente("Leonardo", "Dev", TiposEnumEstadoCivil.Solteiro, TipoEnumTipoPessoa.Fisica , DateTime.Parse("2003-12-12"));


ContaEmpresarial teste = new ContaEmpresarial(100, 5, 0,"21321321321",48984, 4094, pessoa1);
ContaCorrente teste1 = new ContaCorrente(10, 10, pessoa2);

teste1.Depositar(100);
teste1.ExibirSaldo();
teste1.Sacar(10);
teste1.ExibirSaldo();

