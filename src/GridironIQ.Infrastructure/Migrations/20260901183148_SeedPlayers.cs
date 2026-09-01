using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GridironIQ.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedPlayers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "Position", "Team" },
                values: new object[,]
                {
                    { 1, "Christian McCaffrey", "RB", "SF" },
                    { 2, "Trevor Lawrence", "QB", "JAX" },
                    { 3, "DeVonta Smith", "WR", "PHI" },
                    { 4, "Cooper DeJean", "CB", "PHI" },
                    { 5, "Jalen Carter", "DT", "PHI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
