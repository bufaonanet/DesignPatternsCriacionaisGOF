namespace Prototype2;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public abstract Funcionario Clone();
}