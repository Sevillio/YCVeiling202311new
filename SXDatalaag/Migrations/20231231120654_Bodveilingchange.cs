using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class Bodveilingchange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaatsteBod",
                table: "Veiling");

            migrationBuilder.DropColumn(
                name: "MinimumBod",
                table: "Veiling");

            migrationBuilder.AddColumn<int>(
                name: "LaatsteBod",
                table: "Bod",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimumBod",
                table: "Bod",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LaatsteBod",
                table: "Bod");

            migrationBuilder.DropColumn(
                name: "MinimumBod",
                table: "Bod");

            migrationBuilder.AddColumn<int>(
                name: "LaatsteBod",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MinimumBod",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
