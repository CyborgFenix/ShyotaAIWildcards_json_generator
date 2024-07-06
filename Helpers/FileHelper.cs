using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Helpers
{
    public class FileHelper
    {
        public static string[] ReadTextFile(string path)
        {
            string[] lines = Array.Empty<string>();

            try
            {
                lines = File.ReadAllLines(path);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return lines;
        }
    }
}
