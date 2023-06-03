using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.EntitiesTypeConfiguration;

public class CardArtistRepositoryConfiguration
{
    public static void Build(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<CardArtistRepository>()
        //   .HasKey(artist => artist.Id);

        modelBuilder.Entity<CardArtistRepository>()
            .HasMany(artist => artist.CardsTrackRepository)
            .WithOne(track => track.CardArtistRepository)
            .HasForeignKey(track => track.CardArtistRepositoryId)
            .HasPrincipalKey(artist => artist.Id);
    }
}
