using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class CreatingViewInDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                 CREATE VIEW vw_TeamsAndLeagues
                 AS
                 SELECT t.Name, l.Name AS LeagueName
                 FROM Teams AS t
                 LEFT JOIN League AS l ON t.LeagueId = l.Id"
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW vw_TeamsAndLeagues");
        }
    }
}
