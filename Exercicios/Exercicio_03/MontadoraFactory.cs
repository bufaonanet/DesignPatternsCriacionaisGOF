namespace Exercicio3;
using static System.Console;

public class MontadoraFactory
{
    private static Dictionary<string, IMontadora> _montadoras = new()
    {
        { "C", new Chevrolet()},
        { "F", new Ford()},
        { "H", new Honda()}
    };


    public static IMontadora CreateProduct(string montadoraNome)
    {
        if (!_montadoras.ContainsKey(montadoraNome))
            throw new ArgumentException($"A montadora {montadoraNome} não foi criada!");

        return _montadoras[montadoraNome];
    }
}

