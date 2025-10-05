public class CalorieStrategy : INutritionStrategy
{
    public double Calculate(MealPlan mealPlan)
    {
        var totalCalories = 0;
        var mealPlanRecipes = mealPlan.Recipes;

        var allIngredients = mealPlan.Recipes
            .SelectMany(r => r.Ingredients)
            .ToList();

        foreach (var ingredient in allIngredients)
        {
            totalCalories += ingredient.Calories;
        }

        return totalCalories;
    }
}