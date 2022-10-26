namespace Exercicio_02.Products;

public class Univ1Quimica : IAluno
{
    public List<string> Cursos()
    {
        return new List<string> { "Química Orgânica", "Química Analítica", "Química Inorgânica" };
    }
}


