namespace FactoryMethod
{
    public class RJPizzaFactory : PizzaFactoryMethod
    {
        protected override Pizza CriaPizza(string tipo)
        {
            if (tipo.ToUpper().Equals("C"))
            {
                return new RJPizzaCalabresa();
            }

            if (tipo.ToUpper().Equals("M"))
            {
                return new RJPizzaMussarela();
            }

            return null;
        }
    }
}
