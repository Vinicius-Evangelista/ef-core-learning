namespace Domain;

public class Team : BaseDomainModel
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int CoachId { get; set; }
    public Coach Coach { get; set; }

    public int? LeagueId { get; set; }
    public League? League { get; set; }
}
