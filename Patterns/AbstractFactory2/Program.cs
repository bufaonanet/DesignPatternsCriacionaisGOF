using AbstractFactory2.Domain.Enums;
using AbstractFactory2.Domain.Products;
using AbstractFactory2.Factory.AbstractFactory;

//Obtem as fábricas
var boloFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Bolo);
var pizzaFactory = MassasAbstractFactory.CriaFabricaMassas(TipoMassa.Pizza);

//Cria os objetos com base no tipo: Bolo
var bolo1 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Chocolate);
var bolo2 = boloFactory.CriaMassa((TipoMassa)TipoBolo.Laranja);

//Cria os objetos com base no tipo: Pizaa
var pizza1 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Mussarela);
var pizza2 = pizzaFactory.CriaMassa((TipoMassa)TipoPizza.Calabreza);

ExibeDetalhes(bolo1);
ExibeDetalhes(bolo2);
ExibeDetalhes(pizza1);
ExibeDetalhes(pizza2);

Console.ReadLine();

static void ExibeDetalhes(MassaBase massaBase)
{
    Console.WriteLine($"Tipo: {massaBase.TipoMassa}");
    Console.WriteLine(massaBase.Nome);
    Console.WriteLine(massaBase.Ingredientes[0].ToString());
    Console.WriteLine("\n");
}