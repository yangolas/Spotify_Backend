using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities.ModelEntities;

public class InformationMusicRepository
{
    public string? Description { get; set; }
    public TimeSpan Duration { get; set; }
    [Key]
    public int Id { get; set; }
    public string? Img { get; set; }
    public string? Name { get; set; }
    public IEnumerable<CardTrackRepository>? CardsTrackRepository { get; set; }
    public string? Song { get; set; }
}
