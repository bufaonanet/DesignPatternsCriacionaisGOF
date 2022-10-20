namespace Builder;

//ConcretBuild
public class DesktopBuilder : ComputadorBuilder
{
    Computador _computador;  
    public override Computador TipoComputador => _computador;

    public DesktopBuilder()
    {
        _computador = new Computador("Desktop");
    }

    public override void BuildDispositivos()
    {
        Console.WriteLine($"Build Dispositivo no Desktop...");
    }

    public override void BuildSO()
    {
        Console.WriteLine("Build Sistema Operacional no Desktop...");
    }
}