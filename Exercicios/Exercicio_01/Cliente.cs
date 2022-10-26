namespace Exercicio_01;

public class Cliente
{
    private readonly Logger _logger;
    public string Nome { get; set; }

    public Cliente(string nome)
    {
        Nome = nome;
        _logger = Logger.GetLogger();
    }

    public void AtualizaEndereco(string endereco, string cidade)
    {
        _logger.Registrar($"Atualização para ao cliente {endereco} em {DateTime.Now}");
    }
}