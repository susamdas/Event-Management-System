namespace QuickEventSolution.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public int UserType { get; set; } // 1-Admin, 2-Standard, 3-External, 4-Guest
    }

    public static class UserTypeHelper
    {
        public static string GetUserTypeText(int userType)
        {
            return userType switch
            {
                1 => "Admin User",
                2 => "Standard User",
                3 => "External User",
                4 => "Guest User",
                _ => "Unknown"
            };
        }
    }
}
