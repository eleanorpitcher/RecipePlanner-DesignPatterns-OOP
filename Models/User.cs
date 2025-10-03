public abstract class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<string> Preferences { get; set; } = new List<string>();
    public UserRoles UserRole { get; set; }

    public User(int id, string name, List<string> preferences, UserRoles userRole)
    {
        Id = id;
        Name = name;
        Preferences = preferences;
        UserRole = userRole;
    }

    // public void AddRecipeToFavourites(Recipe recipe)
    // {

    // }
}