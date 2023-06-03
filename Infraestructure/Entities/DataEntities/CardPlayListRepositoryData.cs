using Commons;
using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.DataEntities;

public class CardPlayListRepositoryData
{
    public static void SetData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardPlayListRepository>()
            .HasData(
                new CardPlayListRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 1,
                    Img = "https://i1.sndcdn.com/artworks-000558491658-4v2bd8-t500x500.jpg",
                    Name = "Mix Rock",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardPlayListRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 2,
                    Img = "https://www.musicgrotto.com/wp-content/uploads/2021/09/best-songs-of-all-time-graphic-art.jpg",
                    Name = "The Most Heard",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardPlayListRepository
                {
                    Description = "Artist",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 3,
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxDkpIbBPA0JfES8ke5q15Jx_j3FR_0ZrXQw&usqp=CAU",
                    Name = "Super Pop!!",
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardPlayListRepository
                {
                    Description = "Natos y Waor",
                    CardsTrackRepository = new List<CardTrackRepository>(),
                    Id = 4,
                    Img = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQxDkpIbBPA0JfES8ke5q15Jx_j3FR_0ZrXQw&usqp=CAU",
                    Name = "Mix Rap",
                    IsPlay = false,
                    Timespan = DateTime.Now
                }

            );

    }
}
