namespace FactoryMethod
{
    public class SPPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriaPizza(string tipo)
        {
            if (tipo.ToUpper().Equals("C"))
            {
                return new SPPizzaCalabresa();
            }

            if (tipo.ToUpper().Equals("M"))
            {
                return new SPPizzaMussarela();
            }

            return null;
        }
    }
}
