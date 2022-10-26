namespace Exercicio_02.Products;

public class Univ1Fisica : IAluno
{
    public List<string> Cursos()
    {
        return new List<string> { "Física Quântica", "Física Básica", "Física Aplicada" };
    }
}


