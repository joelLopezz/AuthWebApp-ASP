using AuthWebApp.Models;

namespace AuthWebApp.Services
{
    public interface IUserAuthenticationService
    {
        User ValidateUser(string username, string password);
        List<User> GetAllUsers();
    }

    public class UserAuthenticationService : IUserAuthenticationService
    {
        // Usuarios hardcodeados para la práctica
        private readonly List<User> _users = new List<User>
        {
            new User { Id = 1, Username = "admin", Password = "admin123", Email = "admin@example.com" },
            new User { Id = 2, Username = "usuario1", Password = "password123", Email = "usuario1@example.com" },
            new User { Id = 3, Username = "demo", Password = "demo123", Email = "demo@example.com" },
            new User { Id = 4, Username = "test", Password = "test123", Email = "test@example.com" }
        };

        public User ValidateUser(string username, string password)
        {
            return _users.FirstOrDefault(u =>
                u.Username.Equals(username, StringComparison.OrdinalIgnoreCase) &&
                u.Password == password &&
                u.IsActive);
        }

        public List<User> GetAllUsers()
        {
            return _users.Where(u => u.IsActive).ToList();
        }
    }
}