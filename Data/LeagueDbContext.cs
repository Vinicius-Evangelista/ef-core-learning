using System.Reflection;
using Data.View;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Data;


public class LeagueDbContext : DbContext
{
    public DbSet<Team> Teams { get; set; }
    public DbSet<Coach> Coachs { get; set; }
    public DbSet<League> League { get; set; }

    public DbSet<TeamsAndLeaguesView> TeamsAndLeaguesView { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(" Server=localhost;Database=ef-learing;User Id=sa;Password=sesiInd@134;TrustServerCertificate=True").LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging().EnableDetailedErrors();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // this apply the configuration/seed for each configuration file
        // modelBuilder.ApplyConfiguration(new TeamConfiguration());

        // search for the configuraton file by Assembly and apply that
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        // Used for views
        modelBuilder.Entity<TeamsAndLeaguesView>().HasNoKey().ToView("vw_TeamAndLeaguesView");

        // Map for tables that is a little trick to pass to code
        modelBuilder.Entity<TeamsAndLeaguesView>().ToTable("tb_with_trick_name");

        //Used in the case we have a User Funtion on Db
        modelBuilder.HasDbFunction(typeof(LeagueDbContext).GetMethod(nameof(GetEarliestTeamMatch), new [] {typeof(int)})).HasName("GetEarliesMatch");
    }

    public DateTime GetEarliestTeamMatch(int teamId) => throw new NotImplementedException();
}
