using AbstractFactory2.Domain.Enums;
using System.Collections;

namespace AbstractFactory2.Domain.Products;

public abstract class MassaBase
{
    public TipoMassa TipoMassa { get; set; }

    public string Nome { get; set; }

    public ArrayList Ingredientes = new();

    protected MassaBase(string nome, TipoMassa tipoMassa)
    {
        TipoMassa = tipoMassa;
        Nome = nome;
    }
}