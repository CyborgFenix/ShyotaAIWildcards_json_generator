using ShyotaAIWildcards_json_generator.Models;
using ShyotaAIWildcards_json_generator.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Helpers
{

//    using System.Text.Json;
//    using System.Text.Json.Serialization;

//    List<data> _data = new List<data>();
//    _data.Add(new data() { Id = 1, SSN = 2, Message = "Un mensaje" });

//// Serializa a JSON y escribe en un archivo
//string json = JsonSerializer.Serialize(_data);
//    File.WriteAllText(@"ruta/al/archivo.json", json);

    public class JsonHelper
    {
        public static void GenerateJsonFile(WildCard model, string outputPath, string fileNameWithoutExtension)
        {
            string json = JsonSerializer.Serialize(model);
            try
            {
                File.WriteAllText(Path.Combine(outputPath, $"{fileNameWithoutExtension}.json"), json);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
