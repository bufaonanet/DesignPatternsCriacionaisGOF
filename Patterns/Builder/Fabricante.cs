namespace Builder;

//Director
public static class Fabricante
{
    public static void Build(ComputadorBuilder computadorBuilder)
    {
        computadorBuilder.BuildDispositivos();
        computadorBuilder.BuildSO();
    }
}