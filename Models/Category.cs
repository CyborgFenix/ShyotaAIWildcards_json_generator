using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShyotaAIWildcards_json_generator.Models
{
    public class Category
    {
        public string Name { get; set; }
        public List<SubCategory> SubCategories { get; set; } = new List<SubCategory>();

        public Category(string name)
        {
            Name = name;
        }
    }
}
