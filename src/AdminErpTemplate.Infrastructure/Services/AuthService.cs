using AdminErpTemplate.Core.DTOs;
using AdminErpTemplate.Core.Interfaces;

namespace AdminErpTemplate.Infrastructure.Services;

public class AuthService : IAuthService
{
    private static readonly List<(string Id, string Username, string Password, string Email, string FullName, string Role)> DemoUsers = new()
    {
        ("1", "admin", "admin123", "admin@adminerp.com", "Admin User", "Administrator"),
        ("2", "manager", "manager123", "manager@adminerp.com", "Manager User", "Manager"),
        ("3", "user", "user123", "user@adminerp.com", "Regular User", "User")
    };

    public LoginResponse? Authenticate(LoginRequest request)
    {
        var user = DemoUsers.FirstOrDefault(u =>
            u.Username.Equals(request.Username, StringComparison.OrdinalIgnoreCase) &&
            u.Password == request.Password);

        if (user == default)
            return null;

        return new LoginResponse
        {
            Token = $"demo-jwt-token-{Guid.NewGuid():N}",
            RefreshToken = $"demo-refresh-{Guid.NewGuid():N}",
            Expiration = DateTime.UtcNow.AddHours(24),
            User = new UserInfo
            {
                Id = user.Id,
                Username = user.Username,
                Email = user.Email,
                FullName = user.FullName,
                Avatar = $"https://ui-avatars.com/api/?name={Uri.EscapeDataString(user.FullName)}&background=6366f1&color=fff",
                Role = user.Role
            }
        };
    }

    public UserInfo? GetUserById(string userId)
    {
        var user = DemoUsers.FirstOrDefault(u => u.Id == userId);
        if (user == default)
            return null;

        return new UserInfo
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            FullName = user.FullName,
            Avatar = $"https://ui-avatars.com/api/?name={Uri.EscapeDataString(user.FullName)}&background=6366f1&color=fff",
            Role = user.Role
        };
    }
}
