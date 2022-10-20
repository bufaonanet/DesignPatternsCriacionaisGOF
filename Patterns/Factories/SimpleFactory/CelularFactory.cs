namespace SimpleFactory;

internal class CelularFactory
{
    public static ICelular CriaCelular(string nome)
    {
        ICelular celular;

        switch (nome)
        {
            case "N":
                celular = new Nokia();
                break;
            case "A":
                celular = new Iphone();
                break;
            default:
                throw new ApplicationException($"Celular {nome} não foi criado");
        }

        return celular;
    }
}
