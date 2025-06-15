using ShapeToGeoJson.Core;

Console.WriteLine("Conversor \".shp\" para \".geojson\"");

var arquivoLocalizado = false;
var caminhoArquivoShape = string.Empty;
while (!arquivoLocalizado)
{
	Console.WriteLine("Informe o caminho do arquivo Shape:");

	caminhoArquivoShape = Console.ReadLine() ?? string.Empty;
	if (!File.Exists(caminhoArquivoShape))
		Console.WriteLine("Arquivo shape não encontrado!");
	else
		arquivoLocalizado = true;
}

Console.WriteLine("Informe o caminho e nome do arquivo Geojson de saida:");
var caminhoArquivoSaida = Console.ReadLine();
if (!string.IsNullOrEmpty(caminhoArquivoSaida))
{
	try
	{
		Console.WriteLine("Aguarde realizando a conversão...");
		Conversor.ToGeoJson(caminhoArquivoShape, caminhoArquivoSaida);
		Console.WriteLine("Arquivo GeoJSON gerado com sucesso.");
	}
	catch (Exception ex)
	{
		Console.WriteLine("Erro na conversão: " + ex.Message);
	}
}

Console.WriteLine("Pressione qualquer tecla para sair..");
Console.ReadKey();