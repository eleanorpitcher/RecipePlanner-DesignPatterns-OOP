var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//DATA

var spaghetti = new Ingredient(1, "Spaghetti", 200, "grams", new List<IngredientCategory> { IngredientCategory.HighCarb });
var eggs = new Ingredient(2, "Eggs", 3, "pcs", new List<IngredientCategory> { IngredientCategory.Dairy });
var pancetta = new Ingredient(3, "Pancetta", 100, "grams", new List<IngredientCategory> { IngredientCategory.Meat });
var parmesan = new Ingredient(4, "Parmesan Cheese", 50, "grams", new List<IngredientCategory> { IngredientCategory.Protein });

var tomato = new Ingredient(5, "Tomato", 2, "pcs", new List<IngredientCategory> { IngredientCategory.Vegetable });
var oliveOil = new Ingredient(6, "Olive Oil", 1, "tbsp", new List<IngredientCategory> { IngredientCategory.LowCarb });

// Sample recipes
var carbonara = new Recipe(
    id: 1,
    name: "Spaghetti Carbonara",
    ingredients: new List<Ingredient> { spaghetti, eggs, pancetta, parmesan },
    category: "Dinner",
    steps: new List<string>
    {
        "Boil the spaghetti.",
        "Cook pancetta until crispy.",
        "Mix eggs and Parmesan.",
        "Combine spaghetti with pancetta and egg mixture.",
        "Serve with black pepper."
    },
    preparationTime: 30
);

var bruschetta = new Recipe(
    id: 2,
    name: "Tomato Bruschetta",
    ingredients: new List<Ingredient> { tomato, oliveOil, parmesan },
    category: "Snack",
    steps: new List<string>
    {
        "Chop tomatoes and mix with olive oil.",
        "Toast bread slices.",
        "Top bread with tomato mixture and sprinkle Parmesan."
    },
    preparationTime: 15
);

var admin = new AdminUser(
    id: 1,
    name: "Alice",
    preferences: new List<string> { "Vegetarian", "Gluten-Free" }
);

var regularUser = new RegularUser(
    id: 2,
    name: "Bob",
    preferences: new List<string> { "Low Carb" }
);

var mealPlan = new MealPlan(
    userId: regularUser.Id,
    recipes: new List<Recipe> { carbonara, bruschetta }
);

//COMMANDS

// mealPlan.AddRecipe(bruschetta);
// Console.WriteLine(mealPlan.Recipes);

// Repo logic

// IRecipeRepo newRecipeRepo = new RecipeRepo();
// newRecipeRepo.CreateRecipe(bruschetta);
// var allRecipes = newRecipeRepo.GetAllRecipes();


// foreach (var recipe in allRecipes)
// {
//     Console.WriteLine($"{recipe.Name}");
// }

// IUserRepo newUserRepo = new UserRepo();
// newUserRepo.CreateUser(admin);
// var allUsers = newUserRepo.GetAllUsers();

// foreach (var user in allUsers)
// {
//     System.Console.WriteLine($"{user.Name}");
// }

IMealPlanStrategy vegStrategy = new VegetarianStrategy();
var plan = vegStrategy.GeneratePlan(admin, new List<Recipe> { carbonara, bruschetta });


var shoppingListGenerator = new ShoppingListService();
var shoppingList = shoppingListGenerator.GenerateShoppingList(mealPlan);

foreach (var ingredient in shoppingList)
{
    System.Console.WriteLine(ingredient.Name);
}

app.Run();
