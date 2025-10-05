
public class GlutenFreeStrategy : IPreferenceBasedPlanStrategy
{
    public string PreferenceName => "Gluten Free";

    public List<Recipe> GeneratePlan(User user, List<Recipe> availableRecipes)
    {
        if (user.Preferences != null && user.Preferences.Contains("Gluten Free"))
        {
            IEnumerable<Recipe> custPlan =
                from recipe in availableRecipes
                where recipe.Ingredients.All(ingredient => !ingredient.Categories.Contains(IngredientCategory.Gluten))
                select recipe;
            return custPlan.ToList();
        }
        return availableRecipes;
    }
}