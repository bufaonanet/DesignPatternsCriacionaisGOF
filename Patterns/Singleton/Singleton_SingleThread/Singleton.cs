namespace Singleton_SingleThread;
using static System.Console;

public class Singleton
{
    private static Singleton instance;
    private int numeroDeInstancias;

    private Singleton()
    {
        WriteLine("Instanciando dentro do construtor privado");
        numeroDeInstancias++;
        WriteLine($"Número de Instâncias = {numeroDeInstancias}");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}