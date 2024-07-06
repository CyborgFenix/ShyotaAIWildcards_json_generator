using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Helpers
{
    public class DirectoryHelper
    {
        public static string[] GetDirectoriesFromPath(string path)
        {
            string[] dirs = Array.Empty<string>() ;
            try
            {
                dirs = Directory.GetDirectories(path);
                return dirs;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dirs;
        }

        public static string[] GetFilesFromDirectory(string directoryPath)
        {
            string[] files = Array.Empty<string>() ;

            try
            {
                files = Directory.GetFiles(directoryPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return files;
        }
    }
}
