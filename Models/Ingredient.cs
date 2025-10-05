public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    public List<IngredientCategory> Categories { get; set; } = new List<IngredientCategory>();
    public int Calories { get; set; }
    public int Carbs { get; set; }
    public int Protein { get; set; }
    public int Fat { get; set; }

    public Ingredient(int id, string name, int quantity, string unit, List<IngredientCategory> categories, int calories = 0, int carbs = 0, int protein = 0, int fat = 0)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Categories = categories;
        Calories = calories;
        Carbs = carbs;
        Protein = protein;
        Fat = fat;
    }
}