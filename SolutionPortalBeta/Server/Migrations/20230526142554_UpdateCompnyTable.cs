using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutionPortalBeta.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCompnyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Alias",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alias",
                table: "Companies");
        }
    }
}
