using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthentiactionController : ControllerBase
{
    private readonly IAuthenticationService _authService;
    public AuthentiactionController(IAuthenticationService authService)
    {
        _authService = authService;
    }
    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = _authService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        return Ok(authResult);
    }
    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = _authService.Login(request.Email, request.Password);
        return Ok(authResult);
    }
}
