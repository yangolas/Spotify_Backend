using ApiMusic.Models;

namespace ApiMusic.Service;

public interface IAuthService
{
    Task Register(User user);

    void CreatePaswordHash(string password);

    string GetToken(
        string userName,
        IConfiguration configuration
    );

    Task<bool> Login(
        string name, 
        string password
    );

    Task<bool> VerifyPasswordHash(
        string password,
        byte[] passwordHash,
        byte[] passwordSalt
    );

    Task<bool> CheckUsername(string username);
    Task<bool> CheckEmail(string email);

    string RenewToken(string token, IConfiguration configuration);
}