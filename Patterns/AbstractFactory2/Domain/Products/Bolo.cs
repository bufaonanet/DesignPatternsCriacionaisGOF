using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products;

//AbstractProductA
public abstract class Bolo : MassaBase
{
    protected Bolo(string nome, TipoMassa tipoMassa) : base(nome, tipoMassa)
    { }
}
