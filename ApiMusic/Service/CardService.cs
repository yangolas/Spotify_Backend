using ApiMusic.Models;
using ApiMusic.RabbitMq.Commands;
using Commons;
using Infrastructure.Entities;
using Infrastructure.Entities.ModelEntities;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using RabbitMQ.Core.Contracts;


#nullable disable

namespace ApiMusic.Service;

public class CardService : ICardService
{
    private readonly MusicContext _musicContext;
    private readonly IEventBus _bus;
    private const string ENVIROMENT = "Server:Development";
    private readonly string _endPointImg;

    //IRabbitMqService rabbitMqService,
    //IEventBus bus
    public CardService(
        MusicContext musicContext,
        IEventBus bus,
        IConfiguration config
    )
    {
        _musicContext = musicContext;
        //_rabbitMqService = rabbitMqService;
        _bus = bus;
        _endPointImg = $"{config.GetSection(ENVIROMENT).Value}/api/Image/";
    }
   
    public async Task<Card> GetAlbumBasic(int id)
    {
        Card card = await GetAlbum(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.basic.ToString();
        card.Underline = true;
        return card;
    }

    public async Task<Card> GetAlbumNoBasic(int id)
    {
        Card card = await GetAlbum(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.blog.ToString();
        return card;
    }
   
    public async Task<Card> GetArtistBasic(int id)
    {
        Card card = await GetArtist(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.basic.ToString();
        return card;
    }

    public async Task<Card> GetArtistNoBasic(int id)
    {
        Card card = await GetArtist(id);
        if  (card == null) 
        {
            return null; 
        }
        card.CardFormat = CardFormat.circle.ToString();
        return card;
    }

    public async Task<Card> GetPlayListBasic(int id)
    {
        Card card = await GetPlayList(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.basic.ToString();
        return card;
    }

    public async Task<Card> GetPlayListNoBasic(int id)
    {
        Card card = await GetPlayList(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.blog.ToString();
        card.Underline = true;
        return card;
    }

    public async Task<Card> GetTrackBasic(int id) 
    {
        Card card = await GetTrack(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.basic.ToString();
        return card;
    }

    public async Task<Card> GetTrackNoBasic(int id)
    {
        Card card = await GetTrack(id);
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.blog.ToString();
        return card;
    }

    public async Task<IEnumerable<Card>> GetTracksByAlbum(int id)
    {
        CardAlbumRepository album = await _musicContext.CardAlbumRepository
            .Include(album => album.CardsTrackRepository)
            .ThenInclude(album => album.InformationMusicRepository)
            .FirstOrDefaultAsync(album => album.Id == id);

        IEnumerable<Card> cards =  GetCardsByCardsTrackRepository(album.CardsTrackRepository);

        return cards;
    }

    public async Task<IEnumerable<Card>> GetTracksByArtist(int id)
    {
        CardArtistRepository artistAwait = _musicContext.CardArtistRepository
        .Include(artist => artist.CardsTrackRepository)
        .ThenInclude(artist => artist.InformationMusicRepository)
        .FirstOrDefault(artist => artist.Id == id);

        CardArtistRepository artist = await Task.FromResult(artistAwait);

        IEnumerable<Card> cards = GetCardsByCardsTrackRepository(artist.CardsTrackRepository);

        return cards;
    }

    public async Task<IEnumerable<Card>> GetTracksByPlayList(int id)
    {
        CardPlayListRepository playListAwait = _musicContext.CardPlayListRepository
        .Include(playList => playList.CardsTrackRepository)
        .ThenInclude(playList => playList.InformationMusicRepository)
        .FirstOrDefault(artist => artist.Id == id);

        CardPlayListRepository  playList = await Task.FromResult(playListAwait);
        IEnumerable<Card> cards = GetCardsByCardsTrackRepository(playList.CardsTrackRepository);

        return cards;
    }

    public async Task<IEnumerable<Card>> GetTrackByTrack(int id)
    {
        IEnumerable<CardTrackRepository> tracksAwait = _musicContext.CardTrackRepository
        .Include(track => track.InformationMusicRepository)
        .Where(track => track.Id == id);

        IEnumerable<CardTrackRepository> tracks = await Task.FromResult(tracksAwait);

        IEnumerable<Card> cards = GetCardsByCardsTrackRepository(tracks);

        return cards;
    }
    
    public async Task SetStatusPlayerAlbum(int idAlbum, int idTrack) 
    {
        CardAlbumRepository albumAwait = _musicContext.CardAlbumRepository
            .Include(album => album.CardsTrackRepository)
            .FirstOrDefault(album => album.Id == idAlbum);

        CardAlbumRepository album = await Task.FromResult(albumAwait);

        album.IsPlay = album.IsPlay == true?
            false : true;

        CardTrackRepository track = album.CardsTrackRepository
            .FirstOrDefault(track => track.Id == idTrack);

        track.IsPlay = track.IsPlay == true ?
            false : true;

        _musicContext.SaveChanges();
    }

    public async Task SetStatusPlayerArtist(int idArtist, int idTrack)
    {
        CardArtistRepository artistAwait = _musicContext.CardArtistRepository
            .Include(artist => artist.CardsTrackRepository)
            .FirstOrDefault(artist => artist.Id == idArtist);

        CardArtistRepository artist = await Task.FromResult(artistAwait);

        artist.IsPlay = artist.IsPlay == true ?
            false : true;

        CardTrackRepository track = artist.CardsTrackRepository
            .FirstOrDefault(track => track.Id == idTrack);

        track.IsPlay = track.IsPlay == true ?
            false : true;

        _musicContext.SaveChanges();
    }

    public async Task SetStatusPlayerPlayList(int idPlaylist, int idTrack)
    {
        CardPlayListRepository playListAwait = _musicContext.CardPlayListRepository
            .Include(playList => playList.CardsTrackRepository)
            .FirstOrDefault(playList => playList.Id == idPlaylist);

        CardPlayListRepository playList = await Task.FromResult(playListAwait);

        playList.IsPlay = playList.IsPlay == true ?
            false : true;

        CardTrackRepository track = playList.CardsTrackRepository
            .FirstOrDefault(track => track.Id == idTrack);

        track.IsPlay = track.IsPlay == true ?
            false : true;

        _musicContext.SaveChanges();
    }

    public async Task SetStatusPlayerTrack(int id)
    {
        CardTrackRepository trackAwait = _musicContext.CardTrackRepository
            .Include(track => track.CardAlbumRepository)
            .FirstOrDefault(track => track.Id == id);

        CardTrackRepository track = await Task.FromResult(trackAwait);
        
        track.IsPlay = track.IsPlay == true ?
            false : true;

        CardAlbumRepository album = track.CardAlbumRepository;

        if(album != null) 
        {
            album.IsPlay = album.IsPlay == true ?
            false : true;
        }
    }

    public async Task<Card> GetArtist(int id) 
    {
        Card cardArtistRepositoryAwait = _musicContext.CardArtistRepository
                .AsNoTracking()
                .Include(artist => artist.CardsTrackRepository)
                .Where(artist =>
                    artist.Id == id
                )
                .Select(artist => new Card()
                {
                    CardFormat = CardFormat.circle.ToString(),
                    Description = artist.Description,
                    Id = artist.Id,
                    Img = artist.Img,
                    IsPlay = false,
                    RandomNumber = 0,
                    Title = artist.Name,
                    TypeInformation = TypeInformation.artist.ToString(),
                    Underline = true
                }
                )
                .FirstOrDefault();

        Card cardArtistRepository = await Task.FromResult(cardArtistRepositoryAwait);

        return cardArtistRepository;
    }

    public async Task<Card> GetAlbum(int id)
    {
        Card cardAlbumRepository = await _musicContext.CardAlbumRepository
            .AsNoTracking()
            .Include(album => album.CardsTrackRepository)
            .Where(album =>
                album.Id == id
            )
            .Select(album => new Card()
            {
                CardFormat = CardFormat.blog.ToString(),
                Description = album.Description,
                Id = album.Id,
                Img = album.Img,
                IsPlay = false,
                RandomNumber = 0,
                Title = album.Name,
                TypeInformation = TypeInformation.album.ToString(),
                Underline = true
            }
            )
            .FirstOrDefaultAsync();

        return cardAlbumRepository;
    }

    public async Task<Card> GetPlayList(int id)
    {
        Card cardPlayListRepositoryAwait = _musicContext.CardPlayListRepository
                .AsNoTracking()
                .Include(playList => playList.CardsTrackRepository)
                .Where(playList =>
                    playList.Id == id
                )
                .Select(playList => new Card()
                {
                    CardFormat = CardFormat.circle.ToString(),
                    Description = playList.Description,
                    Id = playList.Id,
                    Img = playList.Img,
                    IsPlay = false,
                    RandomNumber = 0,
                    Title = playList.Name,
                    TypeInformation = TypeInformation.playList.ToString(),
                    Underline = true
                }
                )
                .FirstOrDefault();

        Card cardPlayListRepository = await Task.FromResult(cardPlayListRepositoryAwait);

        return cardPlayListRepository;
    }

    public async Task<Card> GetTrack(int id) 
    {
        Card cardTrackRepositoryAwait = _musicContext.CardTrackRepository
                .AsNoTracking()
                .Include(track => track.InformationMusicRepository)
                .AsEnumerable()
                .Where(track =>
                    track.CardArtistRepositoryId == null
                    && track.CardPlayListRepositoryId == null
                //&& !(tracks.Contains(track.Id))
                )
                .Where(trackObj =>
                    trackObj.Id == id
                )
                .Select(trackObj => new Card()
                    {
                        CardFormat = CardFormat.row.ToString(),
                        Description = trackObj.InformationMusicRepository.Description,
                        Id = trackObj.Id,
                        Img = trackObj.InformationMusicRepository.Img,
                        IsPlay = false,
                        RandomNumber = 0,
                        Title = trackObj.InformationMusicRepository.Name,
                        Song = trackObj.InformationMusicRepository.Song,
                        TypeInformation = TypeInformation.track.ToString(),
                        Underline = false,
                        Duration = trackObj.InformationMusicRepository.Duration
                    }
                )
            .FirstOrDefault();

        Card cardTrackRepository = await Task.FromResult(cardTrackRepositoryAwait);

        return cardTrackRepository;
    }

    public async Task<Card> GetArtistHigerTimespan()
    {
        CardArtistRepository artist = await _musicContext.CardArtistRepository
                .AsNoTracking()
                .Include(artist => artist.CardsTrackRepository)
                .OrderByDescending(artist => artist.Timespan)
                .FirstOrDefaultAsync();

        Card card = new()
        {
            CardFormat = CardFormat.circle.ToString(),
            Description = artist.Description,
            Id = artist.Id,
            Img = artist.Img,
            IsPlay = false,
            RandomNumber = 0,
            Title = artist.Name,
            TypeInformation = TypeInformation.artist.ToString(),
            Underline = true
        };

        return card;
    }

    public async Task<Card> GetAlbumHigerTimespan()
    {
        CardAlbumRepository album = await _musicContext.CardAlbumRepository
            .AsNoTracking()
            .Include(album => album.CardsTrackRepository)
            .OrderByDescending(album => album.Timespan)
            .FirstOrDefaultAsync();

        Card card = new()
        {
            CardFormat = CardFormat.blog.ToString(),
            Description = album.Description,
            Id = album.Id,
            Img = album.Img,
            IsPlay = false,
            RandomNumber = 0,
            Title = album.Name,
            TypeInformation = TypeInformation.album.ToString(),
            Underline = true
        };

        return card;
    }

    public async Task<Card> GetPlayListHigerTimespan()
    {
        CardPlayListRepository playList = await _musicContext.CardPlayListRepository
                .AsNoTracking()
                .Include(playList => playList.CardsTrackRepository)
                .OrderByDescending(playList => playList.Timespan)
                .FirstOrDefaultAsync();

        Card card = new Card()
        {
            CardFormat = CardFormat.circle.ToString(),
            Description = playList.Description,
            Id = playList.Id,
            Img = playList.Img,
            IsPlay = false,
            RandomNumber = 0,
            Title = playList.Name,
            TypeInformation = TypeInformation.playList.ToString(),
            Underline = true
        };

        return card;
    }

    public async Task<Card> GetTrackHigerTimespan()
    {
        CardTrackRepository track = await _musicContext.CardTrackRepository
                .AsNoTracking()
                .Include(track => track.InformationMusicRepository)
                .OrderByDescending(track => track.Timespan)
                .FirstOrDefaultAsync();

        Card card = new()
        {
            CardFormat = CardFormat.row.ToString(),
            Description = track.InformationMusicRepository.Description,
            Id = track.Id,
            Img = track.InformationMusicRepository.Img,
            IsPlay = false,
            RandomNumber = 0,
            Title = track.InformationMusicRepository.Name,
            Song = track.InformationMusicRepository.Song,
            TypeInformation = TypeInformation.track.ToString(),
            Underline = false,
            Duration = track.InformationMusicRepository.Duration
        };

        return card;
    }

    public async Task<IEnumerable<Card>> GetCardsByText(string text) 
    { 
        var cards = new List<Card>();

        List<Card> albums = await _musicContext.CardAlbumRepository
            .AsNoTracking ()
            .Where( album => album.Name.Contains(text))
            .Select(album => new Card()
                {
                    CardFormat = CardFormat.blog.ToString(),
                    Description = album.Description,
                    Id = album.Id,
                    Img = album.Img,
                    IsPlay = false,
                    RandomNumber = 0,
                    Title = album.Name,
                    TypeInformation = TypeInformation.album.ToString(),
                    Underline = false
                }
            )
            .ToListAsync();

        List<Card> artists = await _musicContext.CardArtistRepository
           .AsNoTracking()
           .Where(artist => artist.Name.Contains(text))
           .Select(artist => new Card()
               {
                   CardFormat = CardFormat.circle.ToString(),
                   Description = artist.Description,
                   Id = artist.Id,
                   Img = artist.Img,
                   IsPlay = false,
                   RandomNumber = 0,
                   Title = artist.Name,
                   TypeInformation = TypeInformation.artist.ToString(),
                   Underline = false
               }
           )
           .ToListAsync();

        List<Card> playLists = await _musicContext.CardPlayListRepository
          .AsNoTracking()
          .Where(playList => playList.Name.Contains(text))
          .Select(playList => new Card()
              {
                  CardFormat = CardFormat.blog.ToString(),
                  Description = playList.Description,
                  Id = playList.Id,
                  Img = playList.Img,
                  IsPlay = false,
                  RandomNumber = 0,
                  Title = playList.Name,
                  TypeInformation = TypeInformation.playList.ToString(),
                  Underline = false
              }
          )
          .ToListAsync();

        IEnumerable<Card> tracks = await _musicContext.CardTrackRepository
        .AsNoTracking()
        .Include(track => track.InformationMusicRepository)
        .Where(track => track.InformationMusicRepository.Name.Contains(text))
        .GroupBy(track => track.InformationMusicRepositoryId)
        .Select(track => new Card()
        {
            CardFormat = CardFormat.blog.ToString(),
            Description = track.FirstOrDefault().InformationMusicRepository.Description,
            Id = track.FirstOrDefault().Id,
            Img = track.FirstOrDefault().InformationMusicRepository.Img,
            IsPlay = false,
            RandomNumber = 0,
            Title = track.FirstOrDefault().InformationMusicRepository.Name,
            Song = track.FirstOrDefault().InformationMusicRepository.Song,
            TypeInformation = TypeInformation.track.ToString(),
            Underline = false,
            Duration = track.FirstOrDefault().InformationMusicRepository.Duration
        })
        .ToListAsync();

        if (albums != null) 
            cards.AddRange(albums);
        if (artists != null)
            cards.AddRange(artists);
        if (playLists != null)
            cards.AddRange(playLists);
        if (tracks != null)
            cards.AddRange(tracks);

        return cards;
    }

    public async Task<bool> SetCards(IEnumerable<Card> cards) 
    {
        foreach (Card card in cards) 
        {
            string uniqueFileName = $"{Guid.NewGuid().ToString()}-{DateTime.Now.Ticks}";
            string song = uniqueFileName + ".mp3";
            string image = uniqueFileName + ".jpg";

            if (card.Song != null) 
            {
                card.Song = card.Song.Substring(card.Song.IndexOf(',') + 1);
                await _bus.SendCommand(new UploadSongCommand(
                    song, 
                    card.Song)
                );
                card.Song = song;
            }

            card.Img = card.Img.Substring(card.Img.IndexOf(',') + 1);
            await _bus.SendCommand(new UploadImageCommand(
                image,
                card.Img)
            );
            card.Img = image;
        }

        IEnumerable<Card> cardsSong = cards
           .Where(card => card.TypeInformation.ToString() == TypeInformation.track.ToString())
           .Select(card => card);

        Card cardMain = cards.FirstOrDefault(card => 
            card.TypeInformation.ToString() != TypeInformation.track.ToString()
        );

        IEnumerable<InformationMusicRepository> informations = cards
            .Where(card => card.TypeInformation.ToString() == TypeInformation.track.ToString())
            .Select(card => new InformationMusicRepository() 
                { 
                    Description = card.Description,
                    Duration = new TimeSpan(0,2,0),
                    Img = card.Img,
                    Name = card.Title,
                    Song = card.Song,
                }
            )
            .ToList();

        await _musicContext.InformationMusicRepository.AddRangeAsync(informations);

        IEnumerable<CardTrackRepository> tracks = informations
            .Select(information => new CardTrackRepository()
                {
                    InformationMusicRepository = information,
                    Timespan = DateTime.Now
                }
            )
            .ToList();

        await _musicContext.CardTrackRepository.AddRangeAsync(tracks);

        if (cardMain != null ) 
        {
            TypeInformation typeInfo = Enum.Parse<TypeInformation>(cardMain.TypeInformation);


            switch (typeInfo) 
            {
                case TypeInformation.album:
                    CardAlbumRepository album = new()
                    {
                        CardsTrackRepository = tracks,
                        Description = cardMain.Description,
                        Img = cardMain.Img,
                        Name = cardMain.Title,
                        Timespan = DateTime.Now
                    };
                    await _musicContext.CardAlbumRepository.AddAsync(album);
                    break;
                
                case TypeInformation.artist:
                    CardArtistRepository artist = new()
                    {
                        CardsTrackRepository = tracks,
                        Description = "Artist",
                        Img = cardMain.Img,
                        Name = cardMain.Title,
                        Timespan = DateTime.Now
                    };
                    await _musicContext.CardArtistRepository.AddAsync(artist);
                    break;

                case TypeInformation.playList:
                    CardPlayListRepository playList = new()
                    {
                        CardsTrackRepository = tracks,
                        Description = cardMain.Description,
                        Img = cardMain.Img,
                        Name = cardMain.Title,
                        Timespan = DateTime.Now
                    };
                    await _musicContext.CardPlayListRepository.AddRangeAsync(playList);
                    break;

                default: 
                    return false;
            }
        }
        try 
        {
            await _musicContext.SaveChangesAsync();
        }
        catch (Exception ex) 
        {
            var a = ex;
        }

        return true;
    }

    public IEnumerable<Card> GetCardsByCardsTrackRepository(IEnumerable<CardTrackRepository> cardsTrack)
    {
        IEnumerable<Card> cards = cardsTrack
            .Select(track =>
                new Card
                {
                    CardFormat = CardFormat.row.ToString(),
                    Description = track.InformationMusicRepository.Description,
                    Id = track.Id,
                    Img = track.InformationMusicRepository.Img,
                    IsPlay = false,
                    RandomNumber = 0,
                    Song = track.InformationMusicRepository.Song,
                    Title = track.InformationMusicRepository.Name,
                    TypeInformation = TypeInformation.track.ToString(),
                    Underline = false,
                    Duration = track.InformationMusicRepository.Duration
                }
            );

        return cards;
    }

    public async Task<Card> GetTrackNoBasicTimespan()
    {
        Card card = await GetTrackHigerTimespan();
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.blog.ToString();
        return card;
    }

    public async Task<Card> GetAlbumNoBasicTimespan()
    {
        Card card = await GetAlbumHigerTimespan();
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.blog.ToString();
        return card;
    }

    public async Task<Card> GetArtistNoBasicTimespan()
    {
        Card card = await GetArtistHigerTimespan();
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.circle.ToString();
        return card;
    }

    public async Task<Card> GetPlayListNoBasicTimespan()
    {
        Card card = await GetPlayListHigerTimespan();
        if (card == null)
        {
            return null;
        }
        card.CardFormat = CardFormat.blog.ToString();
        return card;
    }
}
