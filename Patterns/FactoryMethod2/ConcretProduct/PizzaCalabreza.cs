using FactoryMethod2.Product;

namespace FactoryMethod2.ConcretProduct;

public class PizzaCalabreza : Pizza
{
    private readonly string _nomePizza;

    public override string Nome { get => _nomePizza; }

    public PizzaCalabreza()
    {
        _nomePizza = "Pizza Calabreza";
        Ingredientes.Add("Fatias de calabreza especial");
        Ingredientes.Add("Queijo parmesão italiano tradicional");
    }
}