using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.EntitiesTypeConfiguration;

public class CardAlbumRepositoryConfiguration
{
    public static void Build(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<CardAlbumRepository>()
        //    .HasKey(album => album.Id);

        modelBuilder.Entity<CardAlbumRepository>()
            .HasMany(album => album.CardsTrackRepository)
            .WithOne(track => track.CardAlbumRepository)
            .HasForeignKey(track => track.CardAlbumRepositoryId)
            .HasPrincipalKey(album => album.Id);
    }
}
