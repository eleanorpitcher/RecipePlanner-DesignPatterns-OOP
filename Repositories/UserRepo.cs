using RecipeApp.Data;
public class UserRepo : IUserRepo
{
    private readonly Database _db;

    public UserRepo(Database db)
    {
        _db = db;
    }
    
    public void CreateUser(User user)
    {
        _db.Users.Add(user);
    }

    public bool DeleteUser(int id)
    {
        var userToDelete = _db.Users.FirstOrDefault(u => u.Id == id);
        if (userToDelete == null) return false;
        _db.Users.Remove(userToDelete);
        return true;
    }

    public bool EditUser(User editedUser)
    {
        var existingUser = _db.Users.FirstOrDefault(u => u.Id == editedUser.Id);
        if (existingUser == null) return false;

        existingUser.Name = editedUser.Name;
        existingUser.Preferences = editedUser.Preferences;
        return true;
    }

    public IEnumerable<User> GetAllUsers()
    {
        return _db.Users;
    }
}