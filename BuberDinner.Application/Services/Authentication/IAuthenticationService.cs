// using BuberDinner.Contracts.Authentication;

namespace BuberDinner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResult Register(string firstName, string lastName, string password, string email);
        AuthenticationResult Login(string email, string password);
    }
}