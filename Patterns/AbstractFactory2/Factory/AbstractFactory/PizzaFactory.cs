using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;

namespace AbstractFactory2.Factory.AbstractFactory;

public class PizzaFactory : MassasAbstractFactory
{
    private readonly Dictionary<TipoPizza, Pizza> _pizzaFactory = new()
    {
        { TipoPizza.Mussarela,new PizzaMussarela() },
        { TipoPizza.Calabreza,new PizzaCalabreza() }

    };

    public override MassaBase CriaMassa(TipoMassa tipoMassa)
    {
        var tipoPizza = (TipoPizza)tipoMassa;
        return _pizzaFactory[tipoPizza];
    }
}

