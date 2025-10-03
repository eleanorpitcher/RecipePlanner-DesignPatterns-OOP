public class MealPlan
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
}