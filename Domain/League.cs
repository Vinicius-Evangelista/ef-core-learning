namespace Domain;

public class League : BaseDomainModel
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public List<Team> Teams { get; set; } = new List<Team>();
}
