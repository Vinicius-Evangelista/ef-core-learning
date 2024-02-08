using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateViewDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(6669));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(6682));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(6684));

            migrationBuilder.UpdateData(
                table: "League",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 59, 35, 965, DateTimeKind.Local).AddTicks(9634));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 99,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 198,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 297,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 396,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 495,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 594,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "League",
                keyColumn: "Id",
                keyValue: 500,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(5319));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(5326));

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatDate",
                value: new DateTime(2024, 2, 8, 9, 55, 6, 278, DateTimeKind.Local).AddTicks(5327));
        }
    }
}
