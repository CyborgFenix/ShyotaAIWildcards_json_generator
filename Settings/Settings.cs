using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Settings
{
    public class Settings
    {
        /*Maybe looking for this folder into 
         * bin\\debug\\net8.0\\ 
         * or 
         * bin\\release\\net8.0\\
         */
        public static readonly string PrincipalFolder = @"Raw_data\Wildcards"; 
        public static readonly string OutputJsonFolder = @"Output_data";
    }
}
