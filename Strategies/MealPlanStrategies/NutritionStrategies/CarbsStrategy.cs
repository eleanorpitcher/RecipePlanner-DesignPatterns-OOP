public class CarbsStrategy : INutritionStrategy
{
    public double Calculate(MealPlan mealPlan)
    {
        var totalCarbs = 0;
        var mealPlanRecipes = mealPlan.Recipes;

        var allIngredients = mealPlan.Recipes
            .SelectMany(r => r.Ingredients)
            .ToList();

        foreach (var ingredient in allIngredients)
        {
            totalCarbs += ingredient.Carbs;
        }

        return totalCarbs;
    }
}