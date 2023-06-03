using Infrastructure.Entities.ModelEntities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities.EntitiesTypeConfiguration;

public class AuthUserConfiguration
{
    public static void Build(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AuthUser>()
           .HasKey(auth => auth.Id);
    }
}
