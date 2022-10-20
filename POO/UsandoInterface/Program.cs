

using UsandoInterface;

var registrarNoConsole = new RegistraOcorrencia(
    new RegistrarNoConsole());
registrarNoConsole.Registrar("Mensagem no console");

var registrarNoArquivo = new RegistraOcorrencia(
    new RegistrarNoArquivo("D:\\marocatti\\DesignPatternsCriacionaisGOF\\POO\\UsandoInterface"));
registrarNoArquivo.Registrar("Registrando no arquivo");

Console.ReadLine();
