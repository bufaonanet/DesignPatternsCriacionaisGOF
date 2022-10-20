namespace AbstractFactory
{
    public class Celular4GFactory : ICelularAbstractFactory
    {
        public ICelularApple CriarCelularApple()
        {
            return new IPhone4G();
        }

        public ICelularNokia CriarCelularNokia()
        {
            return new Nokia4G();            
        }
    }
}
