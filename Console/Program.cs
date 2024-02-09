using Data;
using Domain;
using Microsoft.EntityFrameworkCore;

using var context = new LeagueDbContext();




async Task QueryFilter()
{
    // a way to ignore query filter.
    var coach = context.Coachs.IgnoreQueryFilters();
}

async Task UsingTransaction()
{
    // This is useful for complex adding, or adding in multiple parts.

    var transaction = context.Database.BeginTransaction();
    var league = new League
    {
        Name = "Brasileirão"
    };

    context.Add(league);
    await context.SaveChangesAsync();

    await transaction.CreateSavepointAsync("Leaguecreated");

    var coach = new Coach
    {
        Name = "Tite"
    };

    context.Add(coach);
    await context.SaveChangesAsync();

    var team = new Team
    {
        LeagueId = league.Id,
        Name = "Corinthians",
        CoachId = coach.Id
    };

    context.Add(team);
    context.SaveChangesAsync();

    try
    {
        await transaction.CommitAsync();

    }
    catch (DbUpdateConcurrencyException)
    {
        await transaction.RollbackAsync();
        await transaction.RollbackToSavepointAsync("Leaguecreated");

    }


}

// await ModifingAndGettingHistoric();

async Task ModifingAndGettingHistoric()
{
    // using temporal/historic tables from SQL SERVER
    var team = context.Teams.FirstOrDefault();

    for (int i = 0; i <= 4; i++)
    {
        team.Name = $"TeamName{i}";
        await context.SaveChangesAsync();
    }

    var teamChangeNameHistoric = context.Teams.TemporalAll().Where(t => t.Id == team.Id)
                                                            .ToList();
    foreach (var record in teamChangeNameHistoric)
    {
        Console.WriteLine(record.Name);
    }
}

async Task QueryingScalarType()
{
    var leaguesId = context.Database.SqlQuery<int>($"SELECT Id FROM Leagues").ToList();
}

async Task CallingUserFunctions()
{
    // just in case to call pre-defined db function
    var earliestMatch = context.GetEarliestTeamMatch(1);
}


async Task MixingSql()
{

    var teams = context.Teams.FromSql($"SELECT * FROM Teams")
                             .Where(t => t.Id == 1)
                             .OrderBy(t => t.Id)
                             .Include(t => t.League)
                             .ToList();
}

async Task ExecutingStoredPrecedure()
{

    // Just a examplo to how to run the stored procedure from EF Core.
    var teamId = context.Teams.FirstOrDefault();
    var league = context.Teams.FromSqlInterpolated($"EXEC dbo.StoredProcedureToGetLeagueNameHere {teamId}");
}
// await QueryWithRawSql();
async Task QueryWithRawSql()
{
    //  Never do that, if you don't validate the concatenate string

    //    var teamName = "Barcelona";
    //    var teams = context.Teams.FromSqlRaw($"SELECT * FROM Teams WHERE name = '{teamName}'");
    //
    //    foreach (var team in teams)
    //    {
    //        Console.WriteLine(team.Name);
    //    }

    // Do that instead

    //    var teamName = "Barcelona";
    //    var teamNameParameter = new SqlParameter("teamName", teamName);
    //
    //    var teams = context.Teams.FromSqlRaw($"SELECT * FROM Teams WHERE name = @teamName", teamNameParameter);
    //
    //    foreach (var team in teams)
    //    {
    //        Console.WriteLine(team.Name);
    //    }


    // This is preferable and a new method version
    var teamName = "Barcelona";

    var teams = context.Teams.FromSqlInterpolated($"SELECT  * FROM Teams WHERE name = {teamName}");

    foreach (var team in teams)
    {
        Console.WriteLine(team.Name);
    }
}

//await QueryRelatedData();
async Task QueryRelatedData()
{
    var league = context.League.Include(l => l.Teams
                                 .Where(t => t.Name.Contains("a")))
                                 .FirstOrDefault();

    foreach (var team in league.Teams)
    {
        Console.WriteLine(team.Name);
    }
}

//await ExplicitLoading();

async Task ExplicitLoading()
{
    var league = context.League.FirstOrDefault(l => l.Id == 500);

    Console.WriteLine(league.Name);

    if (!league.Teams.Any())
    {
        Console.WriteLine("No teams");
    }


    // Including related data after the query.
    await context.Entry(league)
                 .Collection(l => l.Teams)
                 .LoadAsync();

    if (league.Teams.Any())
    {
        foreach (var team in league.Teams)
        {
            Console.WriteLine(team.Name);
        }
    }

}

// await  UpdateDirectyFromDataBase();
async Task UpdateDirectyFromDataBase()
{
    // again, we could just bring the entities to memory and update, but we can just update it directly
    // on thedatabase.

    // await context.Teams.Where(t => t.TeamId == 2).ExecuteUpdateAsync(p => p.SetProperty(p => p.Name, "Barcelona"));
    await context.Teams.ExecuteUpdateAsync(p => p.SetProperty(p => p.Name, "Barcelona"));
}

// await DeleteDirectyFromDataBase();
async Task DeleteDirectyFromDataBase()
{
    // Instead to bring to the memory the items that we wan't to delete
    // Let's just remove directly from database

    await context.Coachs.ExecuteDeleteAsync();
}

//await CreateCoach();
async Task CreateCoach()
{
    var coachs = new List<Coach>()
    {
      new Coach()
      {
        Name = "Treinador1",
        CreatDate = DateTime.Now
      },

      new Coach()
      {
        Name = "Treinador2",
        CreatDate = DateTime.Now
      }

    };

    await context.Coachs.AddRangeAsync(coachs);

    foreach (var coach in coachs)
    {
        Console.WriteLine(coach.Id);
        Console.WriteLine(context.ChangeTracker.DebugView.LongView);
    }

    await context.SaveChangesAsync();

    foreach (var coach in coachs)
    {
        Console.WriteLine(coach.Id);
        Console.WriteLine(context.ChangeTracker.DebugView.LongView);
    }
}

var recordCount = 3;
var page = 0;
var next = true;


async Task SkipAndTaking()
{
    var teams = await context.Teams.Skip(page * recordCount).Take(recordCount).ToListAsync();
}

// await QueryableVsEnumerable();

async Task QueryableVsEnumerable()
{

    var input = Console.ReadLine();

    if (input == "1")
    {
        var teamAsList = await context.Teams.ToListAsync();
        teamAsList = teamAsList.Where(t => t.Name.Contains("a")).ToList();

        foreach (var t in teamAsList)
        {
            Console.WriteLine(t.Name);
        }
    }

    if (input == "2")
    {
        var teamAsQueryable = context.Teams.AsQueryable();

        teamAsQueryable = teamAsQueryable.Where(t => t.Name == "Barcelona");

        foreach (var t in teamAsQueryable)
        {
            Console.WriteLine(t.Name);
        }
    }

}

async Task GetAllTeamNamesQuerySyntax()
{
    var teams = await (from team in context.Teams select team).ToListAsync();
}

// GetAllTeamNames(context);

async Task GetAllTeamNames(LeagueDbContext context)
{
    var teams = context.Teams.AsNoTracking().Select(t => t.Name).ToList();

    foreach (var t in teams)
    {
        Console.WriteLine(t);
    }
}

Console.ReadKey();
