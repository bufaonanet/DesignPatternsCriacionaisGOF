using FactoryMethod2.Product;

namespace FactoryMethod2.ConcretProduct;

//ConcreteProduct
public class PizzaPortuguesa : Pizza
{
    private readonly string _nomePizza;
    public PizzaPortuguesa()
    {
        _nomePizza = "Pizza Portuguesa";
        Ingredientes.Add("Queijo parmessão");
        Ingredientes.Add("Ervilhas");
        Ingredientes.Add("Cebola");
        Ingredientes.Add("Ovos cozidos");
    }
    public override string Nome { get => _nomePizza; }
}