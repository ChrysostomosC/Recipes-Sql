using Database;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;

var db = new Database.Database();

Console.Write("Enter Name: ");
string name = Console.ReadLine();

Console.Write("Enter Image: ");
string image = Console.ReadLine();
while (!Uri.IsWellFormedUriString(image, UriKind.Absolute)) //Edw einai pou mas epitrepei na valoume url mias foto ap to internet
{
    Console.WriteLine("The URL is not valid. Please enter a valid ImageUrl:");
    image = Console.ReadLine();
}

Console.WriteLine("Enter Ingredients: ");
string ingredients = Console.ReadLine();

Console.WriteLine("Enter Directions: ");
string directions = Console.ReadLine();


db.SaveRecipe(name, image, ingredients, directions);

var recipes = db.GetRecipes();

foreach (var recipe in recipes)
{
    Console.WriteLine(recipe);
}