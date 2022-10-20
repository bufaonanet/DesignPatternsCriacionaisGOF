

using AbstractFactory;

IMontadora fabrica = new FabricaHonda();
var cliente = new Cliente(fabrica);
Console.WriteLine("******** HONDA *********");
Console.WriteLine(cliente.GetSedanDetalhes());
Console.WriteLine(cliente.GetSuvDetalhes());

fabrica = new FabricaHyundai();
cliente = new Cliente(fabrica);
Console.WriteLine("******** Hyundai *********");
Console.WriteLine(cliente.GetSedanDetalhes());
Console.WriteLine(cliente.GetSuvDetalhes());







