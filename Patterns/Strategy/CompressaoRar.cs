namespace Strategy;

//Concret Strategy
public class CompressaoRar : ICompressao
{
	public void ComprimirArquivo(string nomeArquivo)
	{
		Console.WriteLine($"\nO arquivo {nomeArquivo} foi compactado usando Rar" +
            $"\nUm arquivo comextensão .Rar foi criado");
	}
}
