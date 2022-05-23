using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CoverLetterReview.Data.Migrations
{
    public partial class improvedDataClasses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "RecordInsertDateTime",
                table: "DocumentReview",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "RecordInsertDateTime",
                table: "DocumentFragment",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "DocumentName",
                table: "Document",
                type: "nvarchar(max)",
                nullable: true,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RecordInsertDateTime",
                table: "DocumentReview");

            migrationBuilder.DropColumn(
                name: "RecordInsertDateTime",
                table: "DocumentFragment");

            migrationBuilder.AlterColumn<string>(
                name: "DocumentName",
                table: "Document",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
