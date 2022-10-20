namespace UsandoInterface;

public class RegistrarNoArquivo : IRegistro
{
    private readonly string _caminhoArquivo;

    public RegistrarNoArquivo(string path)
    {
        _caminhoArquivo = path;
    }

    public void RegistraInfo(string mensagem)
    {
        Log(mensagem);
    }

    private void Log(string mensagem)
    {
        using var streamWriter = new StreamWriter(_caminhoArquivo,true);
        streamWriter.WriteLine(mensagem);   
    }
}
