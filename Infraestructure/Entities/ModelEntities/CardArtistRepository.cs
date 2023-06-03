using Commons;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities.ModelEntities;

public class CardArtistRepository
{
    public string? Description { get; set; }
    public int Id { get; set; }
    public IEnumerable<CardTrackRepository>? CardsTrackRepository { get; set; }
    public string? Img { get; set; }
    public string? Name { get; set; }
    public bool IsPlay { get; set; }
    public DateTime Timespan { get; set; }
}
