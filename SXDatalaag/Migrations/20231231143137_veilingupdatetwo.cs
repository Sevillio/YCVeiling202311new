using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class veilingupdatetwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duratie",
                table: "Veiling");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Duratie",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
