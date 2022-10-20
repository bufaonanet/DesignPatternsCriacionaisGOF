
class PizzaCalabresa : Pizza
{
    public PizzaCalabresa()
    {
        Nome = "Calabresa";
    }
    public override void Assar(int tempo)
    {
        Console.WriteLine($"Pizza de {Nome} por {tempo} min.");
    }

    public override void Embalar()
    {
        Console.WriteLine($"Embalando pizza de {Nome} ");
    }

    public override void Preparar()
    {
        Console.WriteLine($"Preparando pizza de {Nome} ");
    }
}