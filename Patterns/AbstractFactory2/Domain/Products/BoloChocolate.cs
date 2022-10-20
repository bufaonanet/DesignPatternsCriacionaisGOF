using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products;

//ProductA1
public sealed class BoloChocolate : Bolo
{
    public BoloChocolate() : base("Bolo de Chocholate", TipoMassa.Bolo)
    {
        Ingredientes.Add("Com cobertura de chocolate Nestlé");
    }
}

//ProductA2
public sealed class BoloLaranja : Bolo
{
    public BoloLaranja() : base("Bolo de Laranja", TipoMassa.Bolo)
    {
        Ingredientes.Add("Com cobertura de calde de laranja");
    }
}


