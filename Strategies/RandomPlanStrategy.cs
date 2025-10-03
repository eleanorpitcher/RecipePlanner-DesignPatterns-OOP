
public class RandomPlanStrategy : IMealPlanStrategy
{
    public List<Recipe> GeneratePlan(User user, List<Recipe> availableRecipes)
    {
        //generate a random recipe from availableRecipes
        Random random = new Random();

        int index = random.Next(availableRecipes.Count);
        Recipe randomPlan = availableRecipes[index];
        Console.WriteLine("Here is your random recipe: " + randomPlan);

        return new List<Recipe> { randomPlan };
    }
}