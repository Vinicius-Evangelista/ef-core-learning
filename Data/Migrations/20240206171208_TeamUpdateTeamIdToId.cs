using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TeamUpdateTeamIdToId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TeamId",
                table: "Teams",
                newName: "Id");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Teams",
                newName: "TeamId");

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2024, 2, 6, 10, 56, 4, 265, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2024, 2, 6, 10, 56, 4, 265, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2024, 2, 6, 10, 56, 4, 265, DateTimeKind.Local).AddTicks(2730));
        }
    }
}
