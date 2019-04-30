using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackPositivity.Services.Migrations
{
    public partial class Disregard : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlackPositivityQuote",
                table: "BlackPositivityQuote");

            migrationBuilder.RenameTable(
                name: "BlackPositivityQuote",
                newName: "BlackPositivityQuotes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlackPositivityQuotes",
                table: "BlackPositivityQuotes",
                column: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlackPositivityQuotes",
                table: "BlackPositivityQuotes");

            migrationBuilder.RenameTable(
                name: "BlackPositivityQuotes",
                newName: "BlackPositivityQuote");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlackPositivityQuote",
                table: "BlackPositivityQuote",
                column: "ID");
        }
    }
}
