namespace AbstractFactory;

public class FabricaHyundai : IMontadora
{
    public ISedan CriaSedan()
    {
        return new HB20Hyundai();
    }

    public ISuv CriaSuv()
    {
        return new CretaHyundai();
    }
}
