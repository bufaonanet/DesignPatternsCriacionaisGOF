using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products;

//AbstractProductb
public abstract class Pizza : MassaBase
{
    protected Pizza(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
    { }
}
