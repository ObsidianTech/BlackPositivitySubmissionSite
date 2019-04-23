using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BlackPositivity.Services.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlackPositivityQuote",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Contributor = table.Column<string>(nullable: true),
                    Quote = table.Column<string>(nullable: true),
                    hasBeenUsed = table.Column<bool>(nullable: false),
                    DateAdded = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlackPositivityQuote", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlackPositivityQuote");
        }
    }
}
