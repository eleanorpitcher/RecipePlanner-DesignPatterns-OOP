public class AdminUser : User
{
	public AdminUser(int id, string name, List<string> preferences) : base(id, name, preferences, UserRoles.Admin)
	{
	}
}