namespace Builder;

public abstract class ComputadorBuilder
{
    public abstract Computador TipoComputador { get; }
    public abstract void BuildSO();
    public abstract void BuildDispositivos();

}
