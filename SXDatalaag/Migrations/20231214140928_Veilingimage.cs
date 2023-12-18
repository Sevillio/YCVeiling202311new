using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class Veilingimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Veilingstuk");
        }
    }
}
