using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TeamAddAutoIncrement : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2024, 2, 5, 15, 16, 10, 530, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2024, 2, 5, 15, 16, 10, 530, DateTimeKind.Local).AddTicks(6465));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "TeamId",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2024, 2, 5, 15, 16, 10, 530, DateTimeKind.Local).AddTicks(6466));
        }
    }
}
