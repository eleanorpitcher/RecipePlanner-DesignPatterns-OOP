public class LowCarbStrategy : IPreferenceBasedPlanStrategy
{
    public string PreferenceName => "Low Carb";
    public List<Recipe> GeneratePlan(User user, List<Recipe> availableRecipes)
    {
        if (user.Preferences != null && user.Preferences.Contains("Low Carb"))
        {
            IEnumerable<Recipe> custPlan =
                from recipe in availableRecipes
                where recipe.Ingredients.All(ingredient => !ingredient.Categories.Contains(IngredientCategory.HighCarb))
                select recipe;
            return custPlan.ToList();
        }
        return availableRecipes;
    }
}