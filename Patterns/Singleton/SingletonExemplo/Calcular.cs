namespace SingletonExemplo;

public class Calcular
{
    private Calcular() { }

    private static Calcular _instance = null;
    private static readonly object lockObj = new();

    public static Calcular Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (lockObj)
                {
                    if (_instance == null)
                    {
                        _instance = new Calcular();
                    }
                }
            }
            return _instance;
        }
    }

    public double Valor1 { get; set; }
    public double Valor2 { get; set; }

    public double Somar()
    {
        return Valor1 + Valor2;
    }
    public double Subtrair()
    {
        return Valor1 - Valor2;
    }
    public double Multiplicar()
    {
        return Valor1 * Valor2;
    }
    public double Dividir()
    {
        return Valor1 / Valor2;
    }
}
