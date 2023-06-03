using ApiMusic.Models;

namespace ApiMusic.Service;

public interface ICardService
{
    Task<Card> GetTrackBasic(int id);
    Task<Card> GetTrackNoBasic(int id);
    Task<Card> GetAlbumBasic(int id);
    Task<Card> GetAlbumNoBasic(int id);
    Task<Card> GetArtistBasic(int id);
    Task<Card> GetArtistNoBasic(int id);
    Task<Card> GetPlayListBasic(int id);
    Task<Card> GetPlayListNoBasic(int id);
    Task<Card> GetTrackNoBasicTimespan();
    Task<Card> GetAlbumNoBasicTimespan();
    Task<Card> GetArtistNoBasicTimespan();
    Task<Card> GetPlayListNoBasicTimespan();
    Task<IEnumerable<Card>> GetTracksByAlbum(int id);
    Task<IEnumerable<Card>> GetTracksByArtist(int id);
    Task<IEnumerable<Card>> GetTracksByPlayList(int id);
    Task<IEnumerable<Card>> GetTrackByTrack(int id);
    Task<IEnumerable<Card>> GetCardsByText(string text);
    Task<bool> SetCards(IEnumerable<Card> cards);
    Task SetStatusPlayerAlbum(int idAlbum, int idTrack);
    Task SetStatusPlayerArtist(int idArtist, int idTrack);
    Task SetStatusPlayerPlayList(int idPlaylist, int idTrack);
    Task SetStatusPlayerTrack(int idTrack);
    Task<Card> GetAlbum(int id);
    Task<Card> GetArtist(int id);
    Task<Card> GetPlayList(int id);
    Task<Card> GetTrack(int id);
}
