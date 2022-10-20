namespace AbstractFactory;

public interface IMontadora
{
    ISuv CriaSuv();
    ISedan CriaSedan();
}

public class Cliente
{
    ISuv suv;
    ISedan sedan;

    public Cliente(IMontadora montadora)
    {
        suv = montadora.CriaSuv();
        sedan = montadora.CriaSedan();
    }

    public string GetSuvDetalhes()
    {
        return suv.ExibeDetalhes();
    }

    public string GetSedanDetalhes()
    {
        return sedan.ExibeDetalhes();
    }
}
