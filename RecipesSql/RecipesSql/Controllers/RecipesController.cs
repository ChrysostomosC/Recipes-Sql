using Microsoft.AspNetCore.Mvc;
using Database;

namespace RecipesSql.Controllers
{
    public class RecipesController : Controller
    {
        public IActionResult Index()
        {
            Database.Database db = new Database.Database();
            List<Recipe> recipes = db.GetRecipes();
            return View(recipes);
        }
    }
}
