using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutionPortalBeta.Server.Migrations
{
    /// <inheritdoc />
    public partial class responsefieldtoCompliants : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachment_UserComplaint_ComplaintId",
                table: "Attachment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attachment",
                table: "Attachment");

            migrationBuilder.RenameTable(
                name: "Attachment",
                newName: "Attachments");

            migrationBuilder.RenameIndex(
                name: "IX_Attachment_ComplaintId",
                table: "Attachments",
                newName: "IX_Attachments_ComplaintId");

            migrationBuilder.AddColumn<string>(
                name: "Response",
                table: "UserComplaint",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attachments",
                table: "Attachments",
                column: "AttachmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachments_UserComplaint_ComplaintId",
                table: "Attachments",
                column: "ComplaintId",
                principalTable: "UserComplaint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Attachments_UserComplaint_ComplaintId",
                table: "Attachments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Attachments",
                table: "Attachments");

            migrationBuilder.DropColumn(
                name: "Response",
                table: "UserComplaint");

            migrationBuilder.RenameTable(
                name: "Attachments",
                newName: "Attachment");

            migrationBuilder.RenameIndex(
                name: "IX_Attachments_ComplaintId",
                table: "Attachment",
                newName: "IX_Attachment_ComplaintId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Attachment",
                table: "Attachment",
                column: "AttachmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Attachment_UserComplaint_ComplaintId",
                table: "Attachment",
                column: "ComplaintId",
                principalTable: "UserComplaint",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
