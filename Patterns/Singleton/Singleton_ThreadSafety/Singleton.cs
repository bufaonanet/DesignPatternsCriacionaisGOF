namespace Singleton_ThreadSafety;
using static System.Console;

public class Singleton
{
    private static Singleton instance;
    private static int contador = 0;
    private static object lockObject = new();

    private Singleton()
    {
        contador++;
        WriteLine($"Instancias {contador}");
    }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {

                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }
}