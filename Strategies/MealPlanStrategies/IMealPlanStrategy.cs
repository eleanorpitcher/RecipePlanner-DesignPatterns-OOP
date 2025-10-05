public interface IMealPlanStrategy //Implements strategy design pattern
{
    List<Recipe> GeneratePlan(User user, List<Recipe> availableRecipes);
}