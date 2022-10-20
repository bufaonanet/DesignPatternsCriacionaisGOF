using Prototype2;

Programador programador = new Programador();
programador.Nome = "Douglas";
programador.Cargo = "Programador Pleno";
programador.Linguagem = "C#";

Programador programadorClone = programador.Clone() as Programador;
programadorClone.Nome = "Lorena";
programadorClone.Cargo = "Programador Júnior";

Console.WriteLine(programador);
Console.WriteLine(programadorClone);

Engenheiro engenheiro = new Engenheiro();
engenheiro.Nome = "Mario";
engenheiro.Cargo = "Engenheiro Mecânico";
engenheiro.Especialidade = "Motores";

Engenheiro engenheiroClone = engenheiro.Clone() as Engenheiro;
engenheiroClone.Nome = "Amanda";
engenheiroClone.Especialidade = "Fluidos";

Console.WriteLine(engenheiro);
Console.WriteLine(engenheiroClone);

Console.ReadLine();