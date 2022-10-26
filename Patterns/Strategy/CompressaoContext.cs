namespace Strategy;

//Context
public class CompressaoContext
{
	private ICompressao _compressaoService;

	public CompressaoContext(ICompressao compressao)
	{
		_compressaoService = compressao;
	}

	public void SetServico(ICompressao compressao)
	{
		_compressaoService = compressao;
	}

	public void CriarArquivoCompactado(string nomeArquivo)
	{
		_compressaoService.ComprimirArquivo(nomeArquivo);
	}

	
}
