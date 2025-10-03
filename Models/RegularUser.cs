public class RegularUser : User
{
	public RegularUser(int id, string name, List<string> preferences) : base(id, name, preferences, UserRoles.Regular)
	{
	}
}