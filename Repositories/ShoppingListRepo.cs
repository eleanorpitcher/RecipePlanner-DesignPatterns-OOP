
using RecipeApp.Data;

public class ShoppingListRepo : IShoppingListRepo
{
    private readonly Database _db;

    public ShoppingListRepo(Database db)
    {
        _db = db;
    }
    public void CreateShoppingList(ShoppingList shoppingList)
    {
        _db.ShoppingLists.Add(shoppingList);
    }

    public bool DeleteShoppingList(int id)
    {
        var shoppingListToDelete = _db.ShoppingLists.FirstOrDefault(s => s.Id == id);
        if (shoppingListToDelete == null) return false;
        _db.ShoppingLists.Remove(shoppingListToDelete);
        return true;
    }

    public bool EditShoppingList(ShoppingList shoppingListToEdit)
    {
        var shoppingList = _db.ShoppingLists.FirstOrDefault(s => s.Id == shoppingListToEdit.Id);
        if (shoppingList == null) return false;
        shoppingList.Ingredients = shoppingListToEdit.Ingredients;
        return true;
    }

    public IEnumerable<ShoppingList> GetAllShoppingLists()
    {
        return _db.ShoppingLists;
    }
}