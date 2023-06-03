using Microsoft.EntityFrameworkCore;
using Infrastructure.Entities.EntitiesTypeConfiguration;
using Infrastructure.Entities.ModelEntities;
using Infrastructure.Entities.DataEntities;

namespace Infrastructure.Entities;

public class MusicContext : DbContext
{
    public DbSet<CardAlbumRepository> CardAlbumRepository { get; set; }
    public DbSet<CardArtistRepository> CardArtistRepository { get; set; }
    public DbSet<CardPlayListRepository> CardPlayListRepository { get; set; }
    public DbSet<CardTrackRepository> CardTrackRepository { get; set; }
    public DbSet<InformationMusicRepository> InformationMusicRepository { get; set; }
    public DbSet<AuthUser> AuthUser { get; set; }
    public MusicContext(DbContextOptions<MusicContext> options) : base(options) {}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        AuthUserConfiguration.Build(modelBuilder);
        InformationMusicRepositoryConfiguration.Build(modelBuilder);
        CardTrackRepositoryConfiguration.Build(modelBuilder);
        CardPlayListRepositoryConfiguration.Build(modelBuilder);
        CardArtistRepositoryConfiguration.Build(modelBuilder);
        CardAlbumRepositoryConfiguration.Build(modelBuilder);
        InformationMusicRepositoryData.SetData(modelBuilder);
        CardTrackRepositoryData.SetData(modelBuilder);
        CardAlbumRepositoryData.SetData(modelBuilder);
        CardArtistRepositoryData.SetData(modelBuilder);
        CardPlayListRepositoryData.SetData(modelBuilder);

    }
}
