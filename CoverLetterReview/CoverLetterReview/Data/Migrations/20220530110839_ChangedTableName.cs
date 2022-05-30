using Microsoft.EntityFrameworkCore.Migrations;

namespace CoverLetterReview.Data.Migrations
{
    public partial class ChangedTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentReview",
                table: "DocumentReview");

            migrationBuilder.RenameTable(
                name: "DocumentReview",
                newName: "DocumentFeedback");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentFeedback",
                table: "DocumentFeedback",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_DocumentFeedback",
                table: "DocumentFeedback");

            migrationBuilder.RenameTable(
                name: "DocumentFeedback",
                newName: "DocumentReview");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DocumentReview",
                table: "DocumentReview",
                column: "ID");
        }
    }
}
