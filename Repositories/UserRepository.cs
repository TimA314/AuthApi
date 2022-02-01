using AuthApi.Models;

namespace AuthApi.Repositories
{
    public class UserRepository
    {
        public static List<User> Users = new()
        {
            new() { UserName = "john_admin", EmailAddress = "john.admin@email.com", Password = "Password1", FirstName = "John", LastName = "Smith", Role = "Administrator" },
            new() { UserName = "jane_standard", EmailAddress = "jane@email.com", Password = "Password2", FirstName = "Jane", LastName = "Doe", Role = "Standard" },

        };
    }
}
