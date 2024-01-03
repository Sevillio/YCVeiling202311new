using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class Newfile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bod_Veiling_VeilingId",
                table: "Bod");

            migrationBuilder.RenameColumn(
                name: "VeilingId",
                table: "Bod",
                newName: "VeilingstukId");

            migrationBuilder.RenameIndex(
                name: "IX_Bod_VeilingId",
                table: "Bod",
                newName: "IX_Bod_VeilingstukId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bod_Veilingstuk_VeilingstukId",
                table: "Bod",
                column: "VeilingstukId",
                principalTable: "Veilingstuk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bod_Veilingstuk_VeilingstukId",
                table: "Bod");

            migrationBuilder.RenameColumn(
                name: "VeilingstukId",
                table: "Bod",
                newName: "VeilingId");

            migrationBuilder.RenameIndex(
                name: "IX_Bod_VeilingstukId",
                table: "Bod",
                newName: "IX_Bod_VeilingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bod_Veiling_VeilingId",
                table: "Bod",
                column: "VeilingId",
                principalTable: "Veiling",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
