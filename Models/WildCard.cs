using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Models
{
    public class WildCard
    {
        string Name { get; set; }
        public List<Category> Categories { get; set; } = new List<Category>();

        public WildCard(string name)
        {
            Name = name;
        }
    }
}
