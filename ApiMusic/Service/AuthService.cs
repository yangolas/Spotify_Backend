using ApiMusic.Models;
using Infrastructure.Entities;
using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.ConstrainedExecution;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace ApiMusic.Service;

public class AuthService: IAuthService
{
    private readonly MusicContext _context;
    public AuthService(MusicContext context)
    {
        _context = context;
    }
    public async Task<bool> CheckUsername(string username)
    {
        AuthUser user = await _context.AuthUser
           .FirstOrDefaultAsync(user => user.UserName == username);

        bool available = user == null
            ? true
            : false;

        return available;
    }
    public async Task<bool> CheckEmail(string email)
    {
        AuthUser user = await _context.AuthUser
           .FirstOrDefaultAsync(user => user.Email == email);

        bool available = user == null
            ? true
            : false;

        return available;
    }
    public async Task<bool> Login(string name, string password)
    {
        AuthUser user = await _context.AuthUser
            .Where(user => 
                user.UserName == name
                || user.Email == name
            )
            .FirstOrDefaultAsync();

        if (user == null)
            return false;

        using (var hmac = new HMACSHA512(user.Salt))
        {
            var computedHash = hmac
                .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

            return computedHash.SequenceEqual(user.Password);
        }
    }
    public async Task Register(User user)
    {
        AuthUser userBD = new ();
        using (var hmac = new HMACSHA512()) 
        { 
            byte[] passwordSalt = hmac.Key;
            byte[] passwordHash = hmac
            .ComputeHash(System.Text.Encoding.UTF8.GetBytes(user.Password));

            userBD.Email = user.Email;
            userBD.Password = passwordHash;
            userBD.Salt = passwordSalt;
            userBD.UserName = user.Username;
        }

        await _context.AuthUser.AddAsync(userBD);
        await _context.SaveChangesAsync();
    }
    public string GetToken(string username, IConfiguration configuration)
    {
        List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, username),
                new Claim(ClaimTypes.Role, "Admin")
            };

        var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
            configuration.GetSection("AppSettings:Token").Value));

        var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);


        //TimeZoneInfo easternZone = TimeZoneInfo.FindSystemTimeZoneById("Romance Standard Time"); 
        //DateTime easternTime = TimeZoneInfo.ConvertTimeFromUtc(DateTime.UtcNow, easternZone); 
        //DateTime adjustedTime = easternTime.AddDays(1); 

        var token = new JwtSecurityToken(
            claims: claims,
            expires: DateTime.Now.AddDays(1),
            signingCredentials: creds);

        var jwt = new JwtSecurityTokenHandler().WriteToken(token);

        return jwt;
    }
    public void CreatePaswordHash(string password)
    {
        throw new NotImplementedException();
    }
    public Task<bool> VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
    {
        throw new NotImplementedException();
    }
    public string RenewToken(string token, IConfiguration configuration) 
    {
        var tokenHandler = new JwtSecurityTokenHandler();




        // Configuración de validación del token
        var validationParameters = new TokenValidationParameters
        {
            ValidateIssuer = false,
            ValidateAudience = false,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(
                Encoding.ASCII.GetBytes(
                    configuration.GetSection("AppSettings:Token").Value
                    )
                )
        };

        ClaimsPrincipal claimsPrincipal = tokenHandler.ValidateToken(token, validationParameters, out var validatedToken);

        return token;
    }
}
