using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class Veilingstatusupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Veiling");
        }
    }
}
