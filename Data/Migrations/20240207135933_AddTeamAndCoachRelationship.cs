using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTeamAndCoachRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CoachId",
                table: "Teams",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LeagueId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "League",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_League", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Coachs",
                columns: new[] { "Id", "CreatDate", "Name" },
                values: new object[,]
                {
                    { 99, new DateTime(2024, 2, 7, 10, 59, 32, 917, DateTimeKind.Local).AddTicks(9394), "Treinador1" },
                    { 198, new DateTime(2024, 2, 7, 10, 59, 32, 917, DateTimeKind.Local).AddTicks(9407), "Treinador2" },
                    { 297, new DateTime(2024, 2, 7, 10, 59, 32, 917, DateTimeKind.Local).AddTicks(9408), "Treinador3" },
                    { 396, new DateTime(2024, 2, 7, 10, 59, 32, 917, DateTimeKind.Local).AddTicks(9409), "Treinador4" },
                    { 495, new DateTime(2024, 2, 7, 10, 59, 32, 917, DateTimeKind.Local).AddTicks(9410), "Treinador5" },
                    { 594, new DateTime(2024, 2, 7, 10, 59, 32, 917, DateTimeKind.Local).AddTicks(9410), "Treinador6" }
                });

            migrationBuilder.InsertData(
                table: "League",
                columns: new[] { "Id", "CreatDate", "Name" },
                values: new object[] { 500, new DateTime(2024, 2, 7, 10, 59, 32, 918, DateTimeKind.Local).AddTicks(1188), "La Liga" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CoachId", "CreatDate", "LeagueId" },
                values: new object[] { 99, new DateTime(2024, 2, 7, 10, 59, 32, 918, DateTimeKind.Local).AddTicks(2483), 500 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CoachId", "CreatDate", "LeagueId" },
                values: new object[] { 198, new DateTime(2024, 2, 7, 10, 59, 32, 918, DateTimeKind.Local).AddTicks(2485), 500 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CoachId", "CreatDate", "LeagueId" },
                values: new object[] { 396, new DateTime(2024, 2, 7, 10, 59, 32, 918, DateTimeKind.Local).AddTicks(2486), 500 });

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CoachId",
                table: "Teams",
                column: "CoachId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams",
                column: "LeagueId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Coachs_CoachId",
                table: "Teams",
                column: "CoachId",
                principalTable: "Coachs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_League_LeagueId",
                table: "Teams",
                column: "LeagueId",
                principalTable: "League",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Coachs_CoachId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_League_LeagueId",
                table: "Teams");

            migrationBuilder.DropTable(
                name: "League");

            migrationBuilder.DropIndex(
                name: "IX_Teams_CoachId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_LeagueId",
                table: "Teams");

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DropColumn(
                name: "CoachId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "LeagueId",
                table: "Teams");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2024, 2, 6, 14, 12, 8, 393, DateTimeKind.Local).AddTicks(4266));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2024, 2, 6, 14, 12, 8, 393, DateTimeKind.Local).AddTicks(4279));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2024, 2, 6, 14, 12, 8, 393, DateTimeKind.Local).AddTicks(4280));
        }
    }
}
