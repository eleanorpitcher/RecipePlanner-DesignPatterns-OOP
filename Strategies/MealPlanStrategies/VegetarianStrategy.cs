
public class VegetarianStrategy : IPreferenceBasedPlanStrategy
{
    public string PreferenceName => "Vegetarian";

    public List<Recipe> GeneratePlan(User user, List<Recipe> availableRecipes)
    {
        if (user.Preferences != null && user.Preferences.Contains("Vegetarian"))
        {
            IEnumerable<Recipe> custPlan =
                from recipe in availableRecipes
                where recipe.Ingredients.All(ingredient => !ingredient.Categories.Contains(IngredientCategory.Meat) && !ingredient.Categories.Contains(IngredientCategory.Fish))
                select recipe;
            return custPlan.ToList();
        }
        return availableRecipes;
    }
}