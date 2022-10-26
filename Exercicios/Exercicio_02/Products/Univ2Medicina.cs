namespace Exercicio_02.Products;

public class Univ2Medicina : IAluno
{
    public List<string> Cursos()
    {
        return new List<string> { "Fisiologia", "Anatomia", "Histologia" };
    }
}


