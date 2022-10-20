namespace Prototype2;

public class Engenheiro : Funcionario
{
    public string Especialidade { get; set; }

    public override Funcionario Clone()
    {
        return MemberwiseClone() as Funcionario;
    }

    public override string ToString()
    {
        return $"{Nome} - {Cargo} - {Especialidade}";
    }
}
