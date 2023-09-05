
public record AuthenticationResult (
    Guid id,
    string FirstName,
    string LastName,
    string Email,
    string Token
);