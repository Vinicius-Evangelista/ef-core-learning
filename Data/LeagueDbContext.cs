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
      // Using  command timout
        optionsBuilder.UseSqlServer(" Server=localhost;Database=ef-learing;User Id=sa;Password=sesiInd@134;TrustServerCertificate=True", sqloptions => sqloptions.CommandTimeout(5)).LogTo(Console.WriteLine, LogLevel.Information).EnableSensitiveDataLogging().EnableDetailedErrors();
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
        //        momelBuilder.HasDbFunction(typeof(LeagueDbContext).GetMethod(nameof(GetEarliestTeamMatch), new { typeof(int) })).HasName("GetEarliesMatch");atch");atch");
    }

    // used for global annotation configuring
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(500);


        base.ConfigureConventions(configurationBuilder);
    }

    // In case we wan't to modifiy the SaveChanges to do some operation.
    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken))
    {
        var entries = ChangeTracker.Entries<BaseDomainModel>().Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);

        foreach(var entry in entries)
        {

            entry.Entity.ModifiedData = DateTime.UtcNow;

            if(entry.State == EntityState.Added)
              entry.Entity.CreatDate = DateTime.UtcNow;
        }

        return base.SaveChangesAsync();
    }

    public DateTime GetEarliestTeamMatch(int teamId) => throw new NotImplementedException();

}
