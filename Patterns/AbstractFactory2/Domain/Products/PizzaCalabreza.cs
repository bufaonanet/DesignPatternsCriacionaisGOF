using AbstractFactory2.Domain.Enums;

namespace AbstractFactory2.Domain.Products;

//ProductB1
public sealed class PizzaCalabreza : Pizza
{
    public PizzaCalabreza() : base("Pizza de Calabreza", TipoMassa.Pizza)
    {
        Ingredientes.Add("Calabreza em cubos e tomates em cubos");
    }
}
