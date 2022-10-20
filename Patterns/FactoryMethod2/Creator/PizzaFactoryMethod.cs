using FactoryMethod2.Product;

namespace FactoryMethod2.Creator;

public abstract class PizzaFactoryMethod
{
    public abstract Pizza CriarPizza(int tipo);
}
