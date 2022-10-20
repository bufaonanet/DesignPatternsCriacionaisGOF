using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;

namespace AbstractFactory2.Factory.AbstractFactory;

//AbstractFactory
public abstract class MassasAbstractFactory
{
    private static readonly Dictionary<TipoMassa, MassasAbstractFactory> _massasFactory = new()
    {
        { TipoMassa.Pizza,new PizzaFactory() },
        { TipoMassa.Bolo,new BoloFactory() },
    };

    public abstract MassaBase CriaMassa(TipoMassa tipoMassa);

    public static MassasAbstractFactory CriaFabricaMassas(TipoMassa tipoMassa)
    {
        return _massasFactory[tipoMassa];
    }
}




