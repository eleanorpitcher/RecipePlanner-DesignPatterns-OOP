public interface IUserRepo
{
    void CreateUser(User user);
    bool DeleteUser(int id);
    bool EditUser(User editedUser);
    IEnumerable<User> GetAllUsers();

}