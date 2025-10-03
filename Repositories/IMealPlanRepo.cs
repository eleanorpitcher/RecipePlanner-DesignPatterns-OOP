public interface IMealPlanRepo
{
    void CreateMealPlan(User user, MealPlan mealPlan);
    bool DeleteMealPlan(User user, int id);
    bool EditMealPlan(User user, MealPlan mealPlan);
    IEnumerable<MealPlan> GetAllMealPlans(User user);
}