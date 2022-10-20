namespace AbstractFactory
{
    public interface ICelularAbstractFactory
    {
        ICelularNokia CriarCelularNokia();
        ICelularApple CriarCelularApple();
    }
}
