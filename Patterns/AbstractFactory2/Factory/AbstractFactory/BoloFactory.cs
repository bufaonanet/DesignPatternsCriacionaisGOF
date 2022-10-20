using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;

namespace AbstractFactory2.Factory.AbstractFactory;

public class BoloFactory : MassasAbstractFactory
{
    private readonly Dictionary<TipoBolo, Bolo> _bolosFactory = new()
    {
        { TipoBolo.Chocolate,new BoloChocolate() },
        { TipoBolo.Laranja,new BoloLaranja() }

    };

    public override MassaBase CriaMassa(TipoMassa tipoMassa)
    {
        var tipoBolo = (TipoBolo)tipoMassa;
        return _bolosFactory[tipoBolo];
    }
}

