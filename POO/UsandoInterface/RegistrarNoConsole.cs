namespace UsandoInterface;

public class RegistrarNoConsole : IRegistro
{
    public void RegistraInfo(string mensagem)
    {
        Console.WriteLine($"{mensagem} : {DateTime.Now}");
    }
}
