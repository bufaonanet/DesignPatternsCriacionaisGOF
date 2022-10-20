using FactoryMethod2.Product;

namespace FactoryMethod2.ConcretProduct;

public class PizzaQuatroQueijos : Pizza
{
    private readonly string _nomePizza;

    public override string Nome { get => _nomePizza; }

    public PizzaQuatroQueijos()
    {
        _nomePizza = "Pizza Quatro Queijos";       
        Ingredientes.Add("Queijo parmessão");
        Ingredientes.Add("Queijo gorgonzola");
        Ingredientes.Add("Queijo Brie");
        Ingredientes.Add("Queijo Provolone");
    }
}
