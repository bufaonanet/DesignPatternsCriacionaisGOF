namespace SemInterface;

public class RegistraOcorrencia
{
    public void RegistraNoConsole(string mensagem)
    {
        Console.WriteLine($"{mensagem} : {DateTime.Now}");
    }

    public void RegistraNoArquivo(string caminho)
    {
        //Registrar no arquivo
    }

    public void RegistraNoBanco(string conexao, string mensagem)
    {
        //Registrar no banco
    }
}
