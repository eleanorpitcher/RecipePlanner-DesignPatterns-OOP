public interface IShoppingListRepo
{
    void CreateShoppingList(ShoppingList shoppingList);
    bool DeleteShoppingList(int id);
    bool EditShoppingList(ShoppingList shoppingList);
    IEnumerable<ShoppingList> GetAllShoppingLists();

}