namespace ApiMusic.Models;

public class User
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string Username { get; set; }
    public int Day { get; set; }
    public int Month { get; set; }
    public int Year { get; set; }
    public string Female { get; set; }
    public string Male { get; set; }
    //public byte[] PasswordHash { get; set; }
    //public byte[] PasswordSalt { get; set; }
    //public string RefreshToken { get; set; } = string.Empty;
    //public DateTime TokenCreated { get; set; }
    //public DateTime TokenExpires { get; set; }
}
