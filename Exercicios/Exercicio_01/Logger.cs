namespace Exercicio_01;

public class Logger
{
    private static Logger _logger;
    private static object _lock = new();

    private Logger() { }

    public static Logger GetLogger()
    {
        if(_logger == null)
        {
            lock (_lock)
            {
                if(_logger == null)
                {
                    _logger = new Logger();
                }

            }
        }
        return _logger;
    }

    public void Registrar(string mensagem)
    {
        Console.WriteLine(mensagem);
    }
}
