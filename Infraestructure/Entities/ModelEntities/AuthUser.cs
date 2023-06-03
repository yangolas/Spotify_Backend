namespace Infrastructure.Entities.ModelEntities;

public class AuthUser
{
    public string Email { get; set; } = string.Empty;
    public int Id { get; set; }
    public byte[] Password { get; set; }
    public byte[] Salt { get; set; }
    public string UserName { get; set; } = string.Empty;
}