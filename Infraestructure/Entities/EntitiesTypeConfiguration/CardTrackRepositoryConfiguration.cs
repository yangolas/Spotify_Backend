using Commons;
using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.EntitiesTypeConfiguration;

public class CardTrackRepositoryConfiguration
{
    public static void Build(ModelBuilder modelBuilder)
    {
        //modelBuilder.Entity<CardTrackRepository>()
        //    .HasKey(track => track.Id);

        modelBuilder.Entity<CardTrackRepository>()
           .HasOne(track => track.InformationMusicRepository)
           .WithMany(information => information.CardsTrackRepository)
           .HasForeignKey(information => information.InformationMusicRepositoryId)
           .HasPrincipalKey(track => track.Id);

        modelBuilder.Entity<CardTrackRepository>()
           .HasOne(track => track.CardAlbumRepository)
           .WithMany(album => album.CardsTrackRepository)
           .HasForeignKey(album => album.CardAlbumRepositoryId)
           .HasPrincipalKey(track => track.Id);

        modelBuilder.Entity<CardTrackRepository>()
          .HasOne(track => track.CardArtistRepository)
          .WithMany(artist => artist.CardsTrackRepository)
          .HasForeignKey(artist => artist.CardArtistRepositoryId)
          .HasPrincipalKey(track => track.Id);

        modelBuilder.Entity<CardTrackRepository>()
          .HasOne(track => track.CardPlayListRepository)
          .WithMany(playList => playList.CardsTrackRepository)
          .HasForeignKey(playList => playList.CardPlayListRepositoryId)
          .HasPrincipalKey(track => track.Id);
       
    }
}
