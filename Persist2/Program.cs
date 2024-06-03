using Controller;

Console.WriteLine("Início da importação de informações sobre radares...");
var administradoras = RadarController.ImportarRadares();

if(administradoras != null)
{
    Console.WriteLine("Importação realizada com sucesso!");
    Console.WriteLine("Quantidade de registros importados: " + administradoras.Count);
}
else
{
    Console.WriteLine("Erro ao importar informações sobre radares.");
}

Console.WriteLine("Início da gravação de informações sobre radares no SqlServer...");
RadarController.InserirRadaresSql(administradoras);

Console.WriteLine("Gera arquivo XML...");
RadarController.GerarRadaresEmXML(administradoras);

Console.ReadKey();
Console.ReadLine();
Console.Clear();