using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.EntitiesTypeConfiguration;

public class CardPlayListRepositoryConfiguration
{
    public static void Build(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<CardPlayListRepository>()
        //    .HasKey(playList => playList.Id);

        modelBuilder.Entity<CardPlayListRepository>()
           .HasMany(playList => playList.CardsTrackRepository)
           .WithOne(track => track.CardPlayListRepository)
           .HasForeignKey(track => track.CardPlayListRepositoryId)
           .HasPrincipalKey(playList => playList.Id);
    }
}
