using Exercicio_02.Products;

namespace Exercicio_02.Factories;

public class Univ1Factory : AlunoFactory
{
    public override IAluno GetAluno(string alunoDepartamento)
    {
        if (alunoDepartamento.Equals("FISICA"))
            return new Univ1Fisica();
        else if (alunoDepartamento.Equals("QUIMICA"))
            return new Univ1Quimica();
        else
            return null;
    }
}