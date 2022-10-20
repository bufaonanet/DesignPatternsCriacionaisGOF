namespace Builder;

//ConcretBuild
public class NoteBookBuilder : ComputadorBuilder
{
    Computador _computador; 
    public override Computador TipoComputador => _computador;

    public NoteBookBuilder()
    {
        _computador = new Computador("NoteBook");
    }
    public override void BuildDispositivos()
    {
        Console.WriteLine("Build Dispositivo no NoteBook...");
    }

    public override void BuildSO()
    {
        Console.WriteLine("Build Sistema Operacional no NoteBook...");
    }
}

