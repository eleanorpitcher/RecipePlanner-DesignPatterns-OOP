public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
    public string Category { get; set; }
    public List<string> Steps { get; set; } = new List<string>();
    public int PreparationTime { get; set; }

    public Recipe(int id, string name, List<Ingredient> ingredients, string category, List<string> steps, int preparationTime)
    {
        Id = id;
        Name = name;
        Ingredients = ingredients;
        Category = category;
        Steps = steps;
        PreparationTime = preparationTime;
    }

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public void RemoveIngredient(Ingredient ingredient)
    {
        Ingredients.Remove(ingredient);
    }

    public void DisplayRecipe()
    {
        System.Console.WriteLine("These are the ingredients for the recipe " + Ingredients + ", and these are the Steps " + Steps);
    }
}