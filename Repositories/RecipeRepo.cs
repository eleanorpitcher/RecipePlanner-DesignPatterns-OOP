//Encapsulate all of the data access logic related to recipes. Separates the business logic from how the data is actually stored/retrieved
using RecipeApp.Data;
public class RecipeRepo : IRecipeRepo
{
    private readonly Database _db;
    private readonly List<IRecipeObserver> _observers = new();
    public RecipeRepo(Database db)
    {
        _db = db;
    }

    public void CreateRecipe(Recipe recipe)
    {
        _db.Recipes.Add(recipe);
    }

    public bool DeleteRecipe(int id)
    {
        var recipeToDelete = _db.Recipes.FirstOrDefault(r => r.Id == id);
        if (recipeToDelete == null) return false;

        _db.Recipes.Remove(recipeToDelete);
        return true;
    }

    public bool EditRecipe(Recipe editedRecipe)
    {
        var existingRecipe = _db.Recipes.FirstOrDefault(r => r.Id == editedRecipe.Id);
        if (existingRecipe == null) return false;

        existingRecipe.Name = editedRecipe.Name;
        existingRecipe.Ingredients = editedRecipe.Ingredients;
        existingRecipe.Category = editedRecipe.Category;
        existingRecipe.Steps = editedRecipe.Steps;
        existingRecipe.PreparationTime = existingRecipe.PreparationTime;

        return true;
    }

    public IEnumerable<Recipe> GetAllRecipes()
    {
        return _db.Recipes;
    }

    public void Attach(IRecipeObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IRecipeObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(Recipe recipe)
    {
        foreach (var observer in _observers)
        {
            observer.Update(recipe);
        }
    }

}