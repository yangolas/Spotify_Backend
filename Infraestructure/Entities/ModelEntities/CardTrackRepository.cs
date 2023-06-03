using Commons;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities.ModelEntities;

public class CardTrackRepository
{
    public int? CardAlbumRepositoryId { get; set; }
    public int? CardArtistRepositoryId { get; set; }
    public int? CardPlayListRepositoryId { get; set; }
    public CardAlbumRepository? CardAlbumRepository { get; set; }
    public CardArtistRepository? CardArtistRepository { get; set; }
    public CardPlayListRepository? CardPlayListRepository { get; set; }
    public int Id { get; set; }
    public int InformationMusicRepositoryId { get; set; }
    public InformationMusicRepository InformationMusicRepository { get; set; }
    public bool IsPlay { get; set; }
    public DateTime Timespan { get; set; }
}
