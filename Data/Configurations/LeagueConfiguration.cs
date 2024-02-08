using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

internal class LeagueConfiguration : IEntityTypeConfiguration<League>
{
    public void Configure(EntityTypeBuilder<League> builder)
    {
        builder.HasKey(t => t.Id);

        builder.HasMany(l => l.Teams).WithOne(t => t.League).HasForeignKey(t => t.LeagueId);

        builder.HasData(
            new League
            {
                Id = 500,
                Name = "La Liga",
                CreatDate = DateTime.Now
            }
            );
    }
}
