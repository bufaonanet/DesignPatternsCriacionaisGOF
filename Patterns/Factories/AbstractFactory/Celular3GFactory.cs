namespace AbstractFactory
{
    public class Celular3GFactory : ICelularAbstractFactory
    {
        public ICelularApple CriarCelularApple()
        {
            return new IPhone3G();
        }

        public ICelularNokia CriarCelularNokia()
        {
            return new Nokia4G();            
        }
    }
}
