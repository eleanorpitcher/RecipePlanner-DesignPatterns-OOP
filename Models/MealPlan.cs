public class MealPlan : IRecipeObserver
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public List<Recipe> Recipes { get; set; } = new List<Recipe>();

    public MealPlan(int userId, List<Recipe> recipes)
    {
        UserId = userId;
        Recipes = recipes;
    }

    public void AddRecipe(Recipe recipe)
    {
        Recipes.Add(recipe);
    }
    public void RemoveRecipe(Recipe recipe)
    {
        Recipes.Remove(recipe);
    }

    public void Update(Recipe updatedRecipe)
    {
        var existingRecipe = Recipes.FirstOrDefault(r => r.Id == updatedRecipe.Id);
        if (existingRecipe != null)
        {
            System.Console.WriteLine($"[MealPlan] Recipe {updatedRecipe.Name} was updated. Refreshing plan...");
            Recipes.Remove(existingRecipe);
            Recipes.Add(updatedRecipe);
        }
        else
        {
            System.Console.WriteLine($"[MealPlan] New recipe '{updatedRecipe.Name}' detected. Adding to plan...");
            Recipes.Add(updatedRecipe);
        }
    }
}