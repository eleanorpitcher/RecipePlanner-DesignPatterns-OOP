public class Ingredient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Unit { get; set; }
    public List<IngredientCategory> Categories { get; set; } = new List<IngredientCategory>();
    public Ingredient(int id, string name, int quantity, string unit, List<IngredientCategory> categories )
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Unit = unit;
        Categories = categories;
    }
}