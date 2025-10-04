namespace RecipeApp.Data
{
    public class Database
    {
        public List<Recipe> Recipes { get; private set; }
        public List<User> Users { get; private set; }
        public List<MealPlan> MealPlans { get; private set; }
        public List<Ingredient> Ingredients { get; private set; }
        public List<ShoppingList> ShoppingLists { get; private set; }

        public Database()
        {
            Recipes = new List<Recipe>();
            Users = new List<User>();
            MealPlans = new List<MealPlan>();
            Ingredients = new List<Ingredient>();
            ShoppingLists = new List<ShoppingList>();
        }
    }
}
