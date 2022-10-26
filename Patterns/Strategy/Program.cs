using Strategy;


Console.WriteLine("## Padrão Strataget ##\n");
Console.WriteLine("Informe o nome do arquivo\n");
var nomeArquivo = Console.ReadLine();


Console.WriteLine("\nInforme o tipo de compressao a ser usada");
Console.WriteLine("1-Rar(Padrão) 2-Zip - 3Gzip\n");
var opcao = Convert.ToInt32(Console.ReadLine());    

CompressaoContext ctx = new(new CompressaoRar());

if(opcao == 2)
{
    ctx.SetServico(new CompressaoZip());
}else if(opcao == 3)
{
    ctx.SetServico(new CompressaoGzip());
}

ctx.CriarArquivoCompactado(nomeArquivo);

Console.Read();