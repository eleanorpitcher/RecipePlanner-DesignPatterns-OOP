public class ProteinStrategy : INutritionStrategy
{
    public double Calculate(MealPlan mealPlan)
    {
        var totalProtein = 0;
        var mealPlanRecipes = mealPlan.Recipes;

        var allIngredients = mealPlan.Recipes
            .SelectMany(r => r.Ingredients)
            .ToList();

        foreach (var ingredient in allIngredients)
        {
            totalProtein += ingredient.Protein;
        }

        return totalProtein;
    }
}