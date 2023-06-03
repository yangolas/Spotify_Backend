using ApiMusic.Models;
using System.Runtime.Serialization;

namespace ApiMusic.Models;


public class Section
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? TitleSize { get; set; }
    public string? Format { get; set; }
    public List<Card>? Cards { get; set; }
}
