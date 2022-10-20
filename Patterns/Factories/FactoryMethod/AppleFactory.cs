namespace FactoryMethod;

public class AppleFactory : CelularFactory
{
    public override ICelular CriarCelular()
    {
        return new IPhone();
    }
}
