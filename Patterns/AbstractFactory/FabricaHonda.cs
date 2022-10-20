namespace AbstractFactory;

public class FabricaHonda : IMontadora
{
    public ISedan CriaSedan()
    {
        return new HondaSivic();
    }

    public ISuv CriaSuv()
    {
        return new HondaCRV();
    }
}
