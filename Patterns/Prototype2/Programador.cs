namespace Prototype2;

public class Programador : Funcionario
{
    public string Linguagem { get; set; }
    public override Funcionario Clone()
    {
        return MemberwiseClone() as Funcionario;
    }

    public override string ToString()
    {
        return $"{Nome} - {Cargo} - {Linguagem}";
    }
}
