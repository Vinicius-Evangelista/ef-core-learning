using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTeams : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "TeamId", "CreatDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 2, 5, 15, 16, 10, 530, DateTimeKind.Local).AddTicks(6454), "Real Madrid" },
                    { 2, new DateTime(2024, 2, 5, 15, 16, 10, 530, DateTimeKind.Local).AddTicks(6465), "Chelsea" },
                    { 3, new DateTime(2024, 2, 5, 15, 16, 10, 530, DateTimeKind.Local).AddTicks(6466), "Barcelona" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3);
        }
    }
}
