//By having an interface for the repository, it implements the abstraction principle

public interface IRecipeRepo
{
    void CreateRecipe(Recipe recipe);
    IEnumerable<Recipe> GetAllRecipes();
    bool EditRecipe(Recipe recipe);
    bool DeleteRecipe(int id);
}