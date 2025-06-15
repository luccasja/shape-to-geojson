using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;

namespace ShapeToGeoJson.Core
{
	public static class Conversor
	{
		public static void ToGeoJson(string path, string outputPath)
		{
			var features = new List<IFeature>();

			using (var reader = new ShapefileDataReader(path, GeometryFactory.Default))
			{
				var header = reader.DbaseHeader;

				while (reader.Read())
				{
					var geometry = reader.Geometry;
					var attributes = new AttributesTable();

					for (int i = 0; i < header.NumFields; i++)
					{
						attributes.Add(header.Fields[i].Name, reader.GetValue(i + 1));
					}

					features.Add(new Feature(geometry, attributes));
				}
			}

			var featureCollection = new FeatureCollection();
			foreach (var feature in features)
			{
				featureCollection.Add(feature);
			}

			var geoJsonWriter = new GeoJsonWriter();
			var geoJson = geoJsonWriter.Write(featureCollection);
			File.WriteAllText(outputPath, geoJson);
		}
	}
}
