using SimpleFactory;


//SemSimpleFactory();

ComSimpleFactory();

static void ComSimpleFactory()
{
    Console.WriteLine("========= Pizzaria ======\n");
    Console.WriteLine("Informe a pizza (C)alabreza  (M)ussarela ");
    var pizzaEscolhida = Console.ReadLine().ToUpper();

    try
    {
        Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida.ToUpper());

        pizza.Preparar();
        pizza.Assar(30);
        pizza.Embalar();
        Console.WriteLine("\nPizza concluida com sucesso");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro :" + ex.Message);
    }
    Console.ReadLine();
}

static void SemSimpleFactory()
{
    Console.WriteLine("========= Pizzaria ======\n");
    Console.WriteLine("Informe a pizza (C)alabreza  (M)ussarela ");
    var pizzaEscolhida = Console.ReadLine().ToUpper();

    try
    {
        //Pizza pizza = PizzaSimpleFactory.CriaPizza(pizzaEscolhida.ToUpper());
        Pizza pizza = null;

        if (pizzaEscolhida.ToUpper().Equals("C"))
        {
            pizza = new PizzaCalabresa();
        }
        else if (pizzaEscolhida.ToUpper().Equals("M"))
        {
            pizza = new PizzaMussarela();
        }
        else
        {
            Console.WriteLine("Pizza inválida!");
            return;
        }

        pizza.Preparar();
        pizza.Assar(30);
        pizza.Embalar();
        Console.WriteLine("\nPizza concluida com sucesso");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro :" + ex.Message);
    }
    Console.ReadLine();
}