using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

internal class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasKey(t => t.Id);
        builder.Property(b => b.Id).ValueGeneratedOnAdd();

        builder.HasOne(t => t.League).WithMany(l => l.Teams).HasForeignKey(t => t.LeagueId);

        builder.HasOne(t => t.Coach).WithOne(c => c.Team).HasForeignKey<Team>(t => t.CoachId);
        
        builder.HasData(
            new Team
            {
                Id = 1,
                CreatDate = DateTime.Now,
                Name = "Real Madrid",
                LeagueId = 500,
                CoachId = 99
            },

            new Team
            {
                Id = 2,
                CreatDate = DateTime.Now,
                Name = "Chelsea",
                LeagueId = 500,
                CoachId = 2 * 99
            },

            new Team
            {
                Id = 3,
                CreatDate = DateTime.Now,
                Name = "Barcelona",
                LeagueId = 500,
                CoachId = 99 * 4
            }
            );
    }
}
