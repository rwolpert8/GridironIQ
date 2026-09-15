using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GridironIQ.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddPlayerRelationshipsAndSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Team",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Players",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "GameLogs",
                columns: new[] { "Id", "FantasyPoints", "Opponent", "PassingYards", "PlayerId", "ReceivingYards", "RushingYards", "Season", "Touchdowns", "Week" },
                values: new object[] { 1, 18.399999999999999, "SEA", 0, 1, 42, 86, 2025, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "TeamId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "TeamId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "TeamId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "TeamId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "TeamId",
                value: 3);

            migrationBuilder.InsertData(
                table: "Projections",
                columns: new[] { "Id", "PlayerId", "ProjectedPoints", "Season", "Week" },
                values: new object[] { 1, 1, 19.199999999999999, 2026, 2 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Abbreviation", "Conference", "Division", "Name" },
                values: new object[,]
                {
                    { 1, "SF", "NFC", "West", "San Francisco 49ers" },
                    { 2, "JAX", "AFC", "South", "Jacksonville Jaguars" },
                    { 3, "PHI", "NFC", "East", "Philadelphia Eagles" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projections_PlayerId",
                table: "Projections",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_TeamId",
                table: "Players",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GameLogs_PlayerId",
                table: "GameLogs",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_GameLogs_Players_PlayerId",
                table: "GameLogs",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projections_Players_PlayerId",
                table: "Projections",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameLogs_Players_PlayerId",
                table: "GameLogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Teams_TeamId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Projections_Players_PlayerId",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Projections_PlayerId",
                table: "Projections");

            migrationBuilder.DropIndex(
                name: "IX_Players_TeamId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_GameLogs_PlayerId",
                table: "GameLogs");

            migrationBuilder.DeleteData(
                table: "GameLogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Projections",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Players");

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "Players",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "Team",
                value: "SF");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "Team",
                value: "JAX");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "Team",
                value: "PHI");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "Team",
                value: "PHI");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "Team",
                value: "PHI");
        }
    }
}
