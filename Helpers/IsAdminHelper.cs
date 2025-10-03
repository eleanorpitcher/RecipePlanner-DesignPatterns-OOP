public static class IsAdminHelper
{
    public static bool IsAdmin(User user)
    {
        if (user.UserRole != UserRoles.Admin)
        {
            Console.WriteLine("You do not have permission to perform this operation.");
            return false;
        }
        else
        {
            return true;
        }
    }
}