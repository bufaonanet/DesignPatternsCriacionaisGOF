using Prototype;
using static System.Console;

Soldado soldado = new ();
soldado.Nome = "Soldado";
soldado.Arma = "Fuzil";
soldado.Acessorio = new Acessorio { Nome = "Capacete" };

Soldado soldado_clone1 = soldado.Clone() as Soldado;
Soldado soldado_clone2 = soldado.Clone() as Soldado;

// atribui valores ao clone1
soldado_clone1.Nome = "Soldado Clone1";
soldado_clone1.Arma = "Bazuca";
soldado_clone1.Acessorio.Nome = "Visor Noturno";

// atribui valores ao clone2
soldado_clone2.Nome = "Soldado Clone2";
soldado_clone2.Arma = "Metralhadora";
soldado_clone2.Acessorio.Nome = "Colete";

//exibe valores do objeto original
WriteLine(">> Objeto Original");
WriteLine($"Nome: {soldado.Nome} - {soldado.Arma}");
WriteLine($"Acessório: {soldado.Acessorio.Nome}");

//Valores de objeto clone1
WriteLine(">> Objeto Clone1");
WriteLine($"Nome: {soldado_clone1.Nome} -  {soldado_clone1.Arma}");
WriteLine($"Acessório: {soldado_clone1.Acessorio.Nome}");

//Valores de objeto clone2
WriteLine(">> Objeto Clone2");
WriteLine($"Nome:{soldado_clone2.Nome} - {soldado_clone2.Arma}");
WriteLine($"Acessório: {soldado_clone2.Acessorio.Nome}");


ReadLine();