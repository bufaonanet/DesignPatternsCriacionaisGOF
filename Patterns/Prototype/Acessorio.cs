namespace Prototype;

public class Acessorio
{
    public string Nome { get; set; }

    public Acessorio Clone()
    {
        return this.MemberwiseClone() as Acessorio;
    }
}
