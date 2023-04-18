using System;
using System.IO;

FileInfo arquivo = null;

try
{
	Console.Write("Digite o nome do arquivo para criá-lo: ");
	string nomeArquivo = Console.ReadLine();
	arquivo = new FileInfo(nomeArquivo);
	using (StreamWriter gravarTexto = File.AppendText(nomeArquivo))
	{
		gravarTexto.WriteLine("Texto que fica dentro do arquivo.");
	}

}
catch (Exception ErroGeralEx)
{
	Console.WriteLine($"Ocorreu o erro: {ErroGeralEx.Message}");
}
finally
{
	Console.WriteLine("Encerrando programa \n");
	arquivo = null;
}



