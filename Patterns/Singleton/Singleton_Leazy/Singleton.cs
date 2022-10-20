namespace Singleton_Leazy;
using static System.Console;

public class Singleton
{
    //eager loading
    //private static readonly Singleton _instance = new();
    
    //leazy loading
    private static readonly Lazy<Singleton> _instance = 
        new Lazy<Singleton>(()=> new Singleton());

    private static int numeroDeInstancias = 0;

    private Singleton()
    {        
        numeroDeInstancias++;
        WriteLine($"Número de Instâncias = {numeroDeInstancias}");
    }

    public static Singleton Instance => _instance.Value;    
}