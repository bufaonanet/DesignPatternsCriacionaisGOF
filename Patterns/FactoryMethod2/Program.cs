using FactoryMethod2.ConcretCreator;
using FactoryMethod2.Product;

Console.WriteLine("Escolha a pizza : ");
Console.WriteLine("(1)Calabreza  (2)Mussarela  (3)Portuguesa " +
    " (4)Quatro Queijos");
var pizzaEscolhida = Convert.ToInt32(Console.ReadLine());

try
{
    PizzaFactory pizzaFactory = new PizzaFactory();
    Pizza pizza = pizzaFactory.CriarPizza(pizzaEscolhida);

    Console.WriteLine(pizza.Nome);

    foreach (var ingrediente in pizza.Ingredientes)
        Console.WriteLine(ingrediente);

    Console.WriteLine("\nPizza concluida com sucesso");
}
catch (Exception ex)
{
    Console.WriteLine("Erro :" + ex.Message);
}
Console.ReadLine();