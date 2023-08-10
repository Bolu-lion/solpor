using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutionPortalBeta.Server.Migrations
{
    /// <inheritdoc />
    public partial class usercomplaintUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "dbo",
                table: "UserComplaint",
                newName: "Role");

            migrationBuilder.RenameColumn(
                name: "CompanyName",
                schema: "dbo",
                table: "UserComplaint",
                newName: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Role",
                schema: "dbo",
                table: "UserComplaint",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Name",
                schema: "dbo",
                table: "UserComplaint",
                newName: "CompanyName");
        }
    }
}
