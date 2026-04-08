using AdminErpTemplate.Core.DTOs;

namespace AdminErpTemplate.Core.Interfaces;

public interface IAuthService
{
    LoginResponse? Authenticate(LoginRequest request);
    UserInfo? GetUserById(string userId);
}
