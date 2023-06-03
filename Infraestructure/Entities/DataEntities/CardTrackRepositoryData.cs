using Commons;
using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.DataEntities;

public class CardTrackRepositoryData
{
    public static void SetData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardTrackRepository>()
            .HasData(
                new CardTrackRepository
                {   
                    CardAlbumRepositoryId = 1,
                    Id = 1,
                    InformationMusicRepositoryId = 14,
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardTrackRepository
                {
                    CardArtistRepositoryId = 4,
                    Id = 2,
                    InformationMusicRepositoryId = 14,
                    IsPlay = false,
                    Timespan = DateTime.Now
                },
                new CardTrackRepository
                {
                    CardPlayListRepositoryId = 4,
                    Id = 3,
                    InformationMusicRepositoryId = 14,
                    IsPlay = false,
                    Timespan = DateTime.Now,
                }
                //new CardTrackRepository
                //{
                //    Id = 4,
                //    InformationMusicRepositoryId = 14,
                //    IsPlay = false
                //}
            );;

    }
}
