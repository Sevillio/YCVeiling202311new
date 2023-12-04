using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class veilingstuktest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "veilingstukId",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Veilingstuk",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aanbieder = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gewicht = table.Column<int>(type: "int", nullable: false),
                    Lengte = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<int>(type: "int", nullable: false),
                    Hoogte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Veilingstuk", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiling_veilingstukId",
                table: "Veiling",
                column: "veilingstukId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiling_Veilingstuk_veilingstukId",
                table: "Veiling",
                column: "veilingstukId",
                principalTable: "Veilingstuk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiling_Veilingstuk_veilingstukId",
                table: "Veiling");

            migrationBuilder.DropTable(
                name: "Veilingstuk");

            migrationBuilder.DropIndex(
                name: "IX_Veiling_veilingstukId",
                table: "Veiling");

            migrationBuilder.DropColumn(
                name: "veilingstukId",
                table: "Veiling");
        }
    }
}
