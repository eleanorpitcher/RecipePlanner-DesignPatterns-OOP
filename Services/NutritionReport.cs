public class NutritionReport
{
    private readonly MealPlan _mealPlan;

    public NutritionReport(MealPlan mealPlan)
    {
        _mealPlan = mealPlan;
    }
    public string CalculateStrategies()
    {
        var newCaloriesStrategy = new CalorieStrategy();
        var newCarbsStrategy = new CarbsStrategy();
        var newProteinStrategy = new ProteinStrategy();
        var newFatStrategy = new FatStrategy();

        var totalCalories = newCaloriesStrategy.Calculate(_mealPlan);
        var totalCarbs = newCarbsStrategy.Calculate(_mealPlan);
        var totalProtein = newProteinStrategy.Calculate(_mealPlan);
        var totalFat = newFatStrategy.Calculate(_mealPlan);

        return $"Here is the nutritional information for your meal plan:\n" +
                    $"Total Calories: {totalCalories}\n" +
                    $"Total Carbs: {totalCarbs}\n" +
                    $"Total Protein: {totalProtein}\n" +
                    $"Total Fat: {totalFat}";
    }
}
