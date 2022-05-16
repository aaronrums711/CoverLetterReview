using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoverLetterReview.Data.Migrations
{
    public partial class baseThreeDataClasss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Document",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    DocumentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IntendedJob = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubmittedByUserID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Document", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentFragment",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseDocumentID = table.Column<int>(type: "int", nullable: false),
                    DocumentFragmentText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentFragment", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentReview",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BaseDocumentID = table.Column<int>(type: "int", nullable: false),
                    DocumentFragmentID = table.Column<int>(type: "int", nullable: false),
                    ReviewCommentText = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentReview", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Document");

            migrationBuilder.DropTable(
                name: "DocumentFragment");

            migrationBuilder.DropTable(
                name: "DocumentReview");
        }
    }
}
