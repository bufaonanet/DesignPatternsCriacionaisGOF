namespace FactoryMethod;

public class NokiaFactory : CelularFactory
{
    public override ICelular CriarCelular()
    {
        return new Nokia();
    }
}
