namespace Prototype;

public class Soldado: ICloneable
{
    public string Nome { get; set; }
    public string Arma { get; set; }
    public Acessorio Acessorio{ get; set; }

    public Soldado() { }
    public Soldado(Soldado s)
    {
        Nome = s.Nome;
        Arma = s.Arma;
        Acessorio = s.Acessorio;
    }

    public object Clone()
    {
        Soldado soldado = this.MemberwiseClone() as Soldado;
        soldado.Acessorio = this.Acessorio.Clone();
        return soldado;   
    }   
}
