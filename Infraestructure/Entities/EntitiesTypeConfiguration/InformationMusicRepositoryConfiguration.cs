using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.EntitiesTypeConfiguration;

public class InformationMusicRepositoryConfiguration
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InformationMusicRepository>()
           .HasKey(information => information.Id);
    }
}
