using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoverLetterReview.Data.Migrations
{
    public partial class RenamedClassAndAddedColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewCompletedDateTime",
                table: "Document",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReviewStartedDateTime",
                table: "Document",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ReviewCompletedDateTime",
                table: "Document");

            migrationBuilder.DropColumn(
                name: "ReviewStartedDateTime",
                table: "Document");
        }
    }
}
