using ShyotaAIWildcards_json_generator.Helpers;
using ShyotaAIWildcards_json_generator.Models;
using ShyotaAIWildcards_json_generator.Settings;


string[] directories = DirectoryHelper.GetDirectoriesFromPath(Path.Combine(Directory.GetCurrentDirectory(), Settings.PrincipalFolder));
WildCard wildCard = new WildCard(Path.GetFileName(Path.Combine(Directory.GetCurrentDirectory(), Settings.PrincipalFolder))); //Wildcards

//string[] directories = DirectoryHelper.GetDirectoriesFromPath(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.ToString(), Settings.PrincipalFolder));
//WildCard wildCard = new WildCard(Path.GetFileName(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.ToString(), Settings.PrincipalFolder))); //Wildcards

Console.WriteLine("Preparing JSON....");
foreach (string directory in directories)
{
    Category category = new Category(Path.GetFileName(directory));

    string[] files = DirectoryHelper.GetFilesFromDirectory(directory);
    foreach (string file in files)
    {
        SubCategory subCategory = new SubCategory()
        {
            Name = Path.GetFileName(file).Split(".")[0],
            Items = FileHelper.ReadTextFile(file).ToList(),
        };

        category.SubCategories.Add(subCategory);
    }

    wildCard.Categories.Add(category);
}

JsonHelper.GenerateJsonFile(wildCard, Path.Combine(Directory.GetCurrentDirectory(), Settings.OutputJsonFolder), "wildcards_data");
Console.WriteLine("Operation Complete!");
Console.WriteLine("File saved in: " + Path.Combine(Directory.GetCurrentDirectory(), Settings.OutputJsonFolder));


