using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

internal class TeamConfiguration : IEntityTypeConfiguration<Team>
{
    public void Configure(EntityTypeBuilder<Team> builder)
    {
        builder.HasKey(t => t.Id);

        // Composite Key Configuration
        builder.HasIndex(t => new {t.Id, t.LeagueId}).IsUnique();

        // Data Notations on Database side.
        builder.Property(t => t.Name).HasMaxLength(500);


        builder.Property(b => b.Id).ValueGeneratedOnAdd();

        // Temporal table from SQL Server
        builder.ToTable("Teams", b => b.IsTemporal());

        builder.HasOne(t => t.League)
               .WithMany(l => l.Teams)
               .HasForeignKey(t => t.LeagueId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(t => t.Coach)
               .WithOne(c => c.Team)
               .HasForeignKey<Team>(t => t.CoachId)
               .OnDelete(DeleteBehavior.Restrict);
        
        builder.HasData(
            new Team
            {
                Id = 1,
                Name = "Real Madrid",
                LeagueId = 500,
                CoachId = 99
            },

            new Team
            {
                Id = 2,
                Name = "Chelsea",
                LeagueId = 500,
                CoachId = 2 * 99
            },

            new Team
            {
                Id = 3,
                Name = "Barcelona",
                LeagueId = 500,
                CoachId = 99 * 4
            }
            );
    }
}
