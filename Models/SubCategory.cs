using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Models
{
    public class SubCategory
    {
        public string Name { get; set; }
        public List<string> Items { get; set; } = new List<string>();
    }
}
