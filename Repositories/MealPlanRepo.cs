using RecipeApp.Data;

public class MealPlanRepo : IMealPlanRepo
{
    private readonly Database _db;

    public MealPlanRepo(Database db)
    {
        _db = db;
    }
    public void CreateMealPlan(User user, MealPlan mealPlan)
    {
        if (IsAdminHelper.IsAdmin(user))
        {
            _db.MealPlans.Add(mealPlan);
        }
    }

    public bool DeleteMealPlan(User user, int id)
    {
        if (IsAdminHelper.IsAdmin(user))
        {
            var recipeToDelete = _db.MealPlans.FirstOrDefault(m => m.Id == id);
            if (recipeToDelete == null) return false;

            _db.MealPlans.Remove(recipeToDelete);
            return true;
        }
        return false;
    }

    public bool EditMealPlan(User user, MealPlan editedMealPlan)
    {
        if (IsAdminHelper.IsAdmin(user))
        {
            var existingMealPlan = _db.MealPlans.FirstOrDefault(r => r.Id == editedMealPlan.Id);
            if (existingMealPlan == null) return false;

            existingMealPlan.Recipes = editedMealPlan.Recipes;
            return true;
        }
        return false;
    }

    public IEnumerable<MealPlan> GetAllMealPlans(User user)
    {
        if (IsAdminHelper.IsAdmin(user))
        {
            return _db.MealPlans;
        }
        return null;
    }
}