using Commons;
using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.DataEntities;

public class CardAlbumRepositoryData
{
    public static void SetData(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CardAlbumRepository>()
            .HasData(
                new CardAlbumRepository
                {
                    Description = "Natos y Waor",
                    Id = 1,
                    Img = "https://www.azlyrics.com/images/albums/112/ed8f1265141816d14948c740f30c6a51.jpg",
                    Name = "Luna Llena",
                    IsPlay = false,
                    Timespan = DateTime.Now
                }
            );

    }
}
