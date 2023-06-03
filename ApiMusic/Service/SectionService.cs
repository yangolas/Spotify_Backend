using ApiMusic.Models;
using Commons;
using Infrastructure.Entities;
using Section = ApiMusic.Models.Section;

namespace ApiMusic.Service;

public class SectionService : ISectionService
{
    private readonly MusicContext _musicContext;
    private readonly ICardService _cardService;
    public SectionService(
        MusicContext musicContext,
        ICardService cardService)
    {
        _musicContext = musicContext;
        _cardService = cardService;
    }

    public async Task<IEnumerable<Section>> GetInitSections()
    {
        List<Section> sections = new List<Section>()
        {
            await GetBigTitleAndMultipleRowFormat(id: 1, title: "Title"),
            await GetSmallViewAllTitleAndOneRowFormat(id: 2, title: "Title 2"),
            await GetSmallTitleAndMultipleRowCostumFormat(id: 3, title: "Title 3")
        };
        
        return sections;
    }

    private async Task<Section> GetBigTitleAndMultipleRowFormat(int id, string title) 
    {
        Section section = new()
        {
            Id = id,
            Title = title,
            TitleSize = SectionTitleSize.big.ToString(),
            Format = SectionFormat.multipleRows.ToString(),
            Cards = new List<Card>()
        };

        Card cardTrack = await _cardService.GetTrackBasic(1);
        section.Cards.Add(cardTrack);

        Card cardArtist = await _cardService.GetArtistBasic(4);
        section.Cards.Add(cardArtist);

        Card cardAlbum = await _cardService.GetAlbumBasic(1);
        section.Cards.Add(cardAlbum);

        Card cardPlayList = await _cardService.GetPlayListBasic(4);
        section.Cards.Add(cardPlayList);

        cardArtist = await _cardService.GetArtistBasic(2);
        section.Cards.Add(cardArtist);

        cardArtist = await _cardService.GetArtistBasic(3);
        section.Cards.Add(cardArtist);

        return section;
    }

    private async Task<Section> GetSmallViewAllTitleAndOneRowFormat(int id, string title) 
    {
        Section section = new()
        {
            Id = id,
            Title = title,
            TitleSize = SectionTitleSize.smallViewAll.ToString(),
            Format = SectionFormat.oneRow.ToString(),
            Cards = new List<Card>()
        };

        await SetSectionWhitNoBasicCards(section);

        return section;
    }

    private async Task<Section> GetSmallTitleAndMultipleRowCostumFormat(int id, string title) 
    {
        Section section = new()
        {
            Id = id,
            Title = title,
            TitleSize = SectionTitleSize.small.ToString(),
            Format = SectionFormat.multipleRowsCustomColumns.ToString(),
            Cards = new List<Card>()
        };

        await SetSectionWhitNoBasicCards(section);

        return section;
    }

    private async Task SetSectionWhitNoBasicCards(Section section) 
    {
        Card cardTrack = await _cardService.GetTrackNoBasicTimespan();
        section.Cards.Add(cardTrack);

        Card cardArtist = await _cardService.GetArtistNoBasicTimespan();
        section.Cards.Add(cardArtist);

        Card cardAlbum = await _cardService.GetAlbumNoBasicTimespan();
        section.Cards.Add(cardAlbum);

        Card cardPlayList = await _cardService.GetPlayListNoBasicTimespan();
        section.Cards.Add(cardPlayList);

        cardTrack = await _cardService.GetTrackNoBasic(1);
        section.Cards.Add(cardTrack);

        cardArtist = await _cardService.GetArtistNoBasic(4);
        section.Cards.Add(cardArtist);

        cardAlbum = await _cardService.GetAlbumNoBasic(1);
        section.Cards.Add(cardAlbum);

        cardPlayList = await _cardService.GetPlayListNoBasic(4);
        section.Cards.Add(cardPlayList);

        cardArtist = await _cardService.GetArtistNoBasic(2);
        section.Cards.Add(cardArtist);

        cardAlbum = await _cardService.GetArtistNoBasic(3);
        section.Cards.Add(cardAlbum);

        //cardPlayList = await _cardService.GetPlayListNoBasic(2);
        //section.Cards.Add(cardPlayList);

        //cardPlayList = await _cardService.GetPlayListNoBasic(3);
        //section.Cards.Add(cardPlayList);

        //cardPlayList = await _cardService.GetPlayListNoBasic(4);
        //section.Cards.Add(cardPlayList);

        //cardAlbum = await _cardService.GetArtistNoBasic(1);
        //section.Cards.Add(cardAlbum);
    }
}
