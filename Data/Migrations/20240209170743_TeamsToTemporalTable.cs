using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class TeamsToTemporalTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Coachs_CoachId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_League_LeagueId",
                table: "Teams");

            migrationBuilder.RenameColumn(
                name: "CreatDate",
                table: "Teams",
                newName: "PeriodStart");

            migrationBuilder.AlterTable(
                name: "Teams")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Teams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "CoachId",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PeriodStart",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "PeriodEnd",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedData",
                table: "League",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedData",
                table: "Coachs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "tb_with_trick_name",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LeagueName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(1484), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(1495), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(1522), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(1523), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(1524), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Coachs",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(1525), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "League",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CreatDate", "ModifiedData" },
                values: new object[] { new DateTime(2024, 2, 9, 14, 7, 43, 476, DateTimeKind.Local).AddTicks(3267), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Coachs_CoachId",
                table: "Teams",
                column: "CoachId",
                principalTable: "Coachs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_League_LeagueId",
                table: "Teams",
                column: "LeagueId",
                principalTable: "League",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
                name: "tb_with_trick_name");

            migrationBuilder.DropColumn(
                name: "PeriodEnd",
                table: "Teams")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.DropColumn(
                name: "ModifiedData",
                table: "League");

            migrationBuilder.DropColumn(
                name: "ModifiedData",
                table: "Coachs");

            migrationBuilder.RenameColumn(
                name: "PeriodStart",
                table: "Teams",
                newName: "CreatDate")
                .Annotation("SqlServer:IsTemporal", true)
                .Annotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .Annotation("SqlServer:TemporalHistoryTableSchema", null)
                .Annotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .Annotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterTable(
                name: "Teams")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Teams",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "LeagueId",
                table: "Teams",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "CoachId",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Teams",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:Identity", "1, 1")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatDate",
                table: "Teams",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2")
                .OldAnnotation("SqlServer:IsTemporal", true)
                .OldAnnotation("SqlServer:TemporalHistoryTableName", "TeamsHistory")
                .OldAnnotation("SqlServer:TemporalHistoryTableSchema", null)
                .OldAnnotation("SqlServer:TemporalPeriodEndColumnName", "PeriodEnd")
                .OldAnnotation("SqlServer:TemporalPeriodStartColumnName", "PeriodStart");

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
    }
}
