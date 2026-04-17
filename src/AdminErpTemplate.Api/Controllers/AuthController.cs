using AdminErpTemplate.Core.DTOs;
using AdminErpTemplate.Core.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AdminErpTemplate.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IAuthService _authService;

    public AuthController(IAuthService authService)
    {
        _authService = authService;
    }

    [HttpPost("login")]
    public ActionResult<ApiResponse<LoginResponse>> Login([FromBody] LoginRequest request)
    {
        var result = _authService.Authenticate(request);
        if (result == null)
        {
            return Unauthorized(new ApiResponse<LoginResponse>
            {
                Success = false,
                Message = "Invalid username or password",
                Errors = new List<string> { "Authentication failed" }
            });
        }

        return Ok(new ApiResponse<LoginResponse>
        {
            Success = true,
            Message = "Login successful",
            Data = result
        });
    }

    [HttpGet("user/{id}")]
    public ActionResult<ApiResponse<UserInfo>> GetUser(string id)
    {
        var user = _authService.GetUserById(id);
        if (user == null)
        {
            return NotFound(new ApiResponse<UserInfo>
            {
                Success = false,
                Message = "User not found"
            });
        }

        return Ok(new ApiResponse<UserInfo>
        {
            Success = true,
            Data = user
        });
    }
}
