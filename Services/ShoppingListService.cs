public class ShoppingListService
{
    public List<Ingredient> GenerateShoppingList(MealPlan mealPlan)
    {
        var mealPlanRecipes = mealPlan.Recipes;

        var allIngredients = mealPlan.Recipes
            .SelectMany(r => r.Ingredients)
            .ToList();

        var groupedIngredients = allIngredients.
            GroupBy(i => i.Name);

        var uniqueIngredients = groupedIngredients.
            Select(g => g.First()).
            ToList();
       
        return uniqueIngredients;
    }
}