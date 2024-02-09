using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration;

internal class CoachConfiguration : IEntityTypeConfiguration<Coach>
{
    public void Configure(EntityTypeBuilder<Coach> builder)
    {
        builder.HasOne(c => c.Team).WithOne(t => t.Coach).HasForeignKey<Team>(t => t.CoachId);
        
        // Configuring some globals queries, any time we query this  table, it gonna run together
        builder.HasQueryFilter(t => t.Name.Contains("a"));

        builder.HasKey(p => p.Id);
        builder.HasData(

                new Coach()
                {
                    Id = 1 * 99,
                    Name = "Treinador1",
                    CreatDate = DateTime.Now
                },

                new Coach()
                {
                    Id = 2 * 99,
                    Name = "Treinador2",
                    CreatDate = DateTime.Now
                },

                new Coach()
                {
                    Id = 3 * 99,
                    Name = "Treinador3",
                    CreatDate = DateTime.Now
                },

                new Coach()
                {
                    Id = 4 * 99,
                    Name = "Treinador4",
                    CreatDate = DateTime.Now
                },

                new Coach()
                {
                    Id = 5 * 99,
                    Name = "Treinador5",
                    CreatDate = DateTime.Now
                },

                new Coach()
                {
                    Id = 6 * 99,
                    Name = "Treinador6",
                    CreatDate = DateTime.Now
                }

          );
    }
}
