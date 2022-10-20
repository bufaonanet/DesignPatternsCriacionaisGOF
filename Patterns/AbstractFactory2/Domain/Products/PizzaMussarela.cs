using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products;

//ProductB2
public sealed class PizzaMussarela : Pizza
{
    public PizzaMussarela() : base("Pizza de Mussarela", TipoMassa.Pizza)
    {
        Ingredientes.Add("Mussarela fatiada e queijo");
    }
}

