namespace Domain;


public class Coach : BaseDomainModel 
{
    public int Id { get; set; } // Mapped to PK
    public string? Name { get; set; } // Mapped to VARCHAR type
}


public class Team : BaseDomainModel 
{
    public int TeamId { get; set; }
    public string? Name { get; set; }
}
