using Commons;
using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.DataEntities;

public class CardArtistRepositoryData
{
    public static void SetData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardArtistRepository>()
            .HasData(
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 1,
                    Img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs",
                    Name = "David Guetta",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 2,
                    Img = "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG",
                    Name = "Armin Van Buuren",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 3,
                    Img = "https://localhost:7250/api/Image/Patri.jpg",
                    Name = "Patrizienta 👸💕",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 4,
                    Img = "https://www.wag1mag.com/wp-content/uploads/natos-y-waor-icaro-wag1mag.jpg",
                    Name = "Natos y Waor",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 5,
                    Img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs",
                    Name = "Artic Monkeys",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 6,
                    Img = "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG",
                    Name = "The Strokes",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 7,
                    Img = "https://lastfm.freetls.fastly.net/i/u/300x300/afc17efeec086dfeab2ba379fe8fa672.jpg",
                    Name = "Dover",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 8,
                    Img = "https://i.ytimg.com/vi/5jsF-CAcgwE/maxresdefault.jpg",
                    Name = "Mägo de Oz",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 9,
                    Img = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/9fc5200a-b94d-4753-ac39-e98e7c9377f0/d8vhdjz-8c3a59a7-255e-4031-83ca-2056b9d17a17.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzlmYzUyMDBhLWI5NGQtNDc1My1hYzM5LWU5OGU3YzkzNzdmMFwvZDh2aGRqei04YzNhNTlhNy0yNTVlLTQwMzEtODNjYS0yMDU2YjlkMTdhMTcuanBnIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.KHtICShMnLtqo-bGALdzRz0HRDAnQjWAyJVKkqbARDs",
                    Name = "DVRST",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardArtistRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 10,
                    Img = "https://onecms-res.cloudinary.com/image/upload/s--_A0VQVVp--/c_crop,h_774,w_1033,x_15,y_218/c_fill,g_auto,h_523,w_693/f_auto,q_auto/v1/mediacorp/cna/image/2022/08/18/zo22_armin.jpg?itok=zHe4UbVG",
                    Name = "Michael Jackson",
                    IsPlay = false,
                    Timespan = DateTime.Now
                }
            );

    }
}
