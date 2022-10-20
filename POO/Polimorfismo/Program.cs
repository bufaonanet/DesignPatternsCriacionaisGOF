using Polimorfismo;

var listaFiguras = new List<Figura> { 
    new Circulo(), new Triangulo() 
};

foreach (var figura in listaFiguras)
{
    figura.Desenhar();
}

Console.ReadLine();
