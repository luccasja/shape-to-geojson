# ShapeToGeoJson

Conversor simples de arquivos **Shapefile (.shp)** para **GeoJSON (.geojson)** utilizando .NET 8 e a biblioteca **NetTopologySuite**.

## 📦 Funcionalidade

O `ShapeToGeoJson` lê um arquivo `.shp` e converte seu conteúdo para o formato **GeoJSON**, preservando geometrias e atributos.

## 🚀 Como utilizar

### Pré-requisitos

- .NET 8 SDK
- Pacotes NuGet necessários:
  - `NetTopologySuite`
  - `NetTopologySuite.IO.ShapeFile`
  - `NetTopologySuite.IO.GeoJSON`

Instalação dos pacotes:

```bash
dotnet add package NetTopologySuite
dotnet add package NetTopologySuite.IO.ShapeFile
dotnet add package NetTopologySuite.IO.GeoJSON
```

### Exemplo de uso

```csharp
using ShapeToGeoJson.Core;

var inputPath = @"caminho/para/arquivo.shp";
var outputPath = @"caminho/para/saida.geojson";

Conversor.ToGeoJson(inputPath, outputPath);
```

### Argumentos

| Parâmetro    | Descrição                                      |
| ------------ | ---------------------------------------------- |
| `path`       | Caminho completo do arquivo `.shp` de entrada. |
| `outputPath` | Caminho de saída do arquivo `.geojson` gerado. |

## 📂 Estrutura do Projeto

```
ShapeToGeoJson
└── Core
    └── Conversor.cs
```

## 🗙️ Dependências técnicas

- **NetTopologySuite**: manipulação de geometrias.
- **NetTopologySuite.IO.ShapeFile**: leitura de arquivos `.shp`.
- **NetTopologySuite.IO.GeoJSON**: escrita de arquivos `.geojson`.

## 📝 Licença

Este projeto é open-source sob a licença MIT. Sinta-se livre para utilizar e contribuir.
