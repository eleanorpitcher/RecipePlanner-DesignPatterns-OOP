public class FatStrategy : INutritionStrategy
{
    public double Calculate(MealPlan mealPlan)
    {
        var totalFat = 0;
        var mealPlanRecipes = mealPlan.Recipes;

        var allIngredients = mealPlan.Recipes
            .SelectMany(r => r.Ingredients)
            .ToList();

        foreach (var ingredient in allIngredients)
        {
            totalFat += ingredient.Fat;
        }

        return totalFat;
    }
}