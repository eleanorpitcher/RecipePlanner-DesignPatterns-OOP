public class ShoppingList
{
    public int Id { get; set; }
    public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();

    public ShoppingList(int id, List<Ingredient> ingredients)
    {
        Id = id;
        Ingredients = ingredients;
    }

    public void AddToShoppingList(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public void RemoveFromShoppingList(Ingredient ingredient)
    {
        Ingredients.Remove(ingredient);
    }
}