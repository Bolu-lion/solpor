using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutionPortalBeta.Server.Migrations
{
    /// <inheritdoc />
    public partial class updatecomplaint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "UserComplaint",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "UserComplaint");
        }
    }
}
