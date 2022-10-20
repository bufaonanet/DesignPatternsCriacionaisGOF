namespace Singleton_Static;
using static System.Console;

public sealed class Singleton
{
    private static Singleton _instance;
    private static int _contadorInstancias;

    private Singleton() { }
    static Singleton()
    {
        _contadorInstancias++;
        WriteLine($"Número de Instâncias = {_contadorInstancias}");
        _instance = new Singleton();
    }

    public static Singleton Instance => _instance;
}