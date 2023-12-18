using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class Veilingstuken : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiling_Veilingstuk_veilingstukId",
                table: "Veiling");

            migrationBuilder.RenameColumn(
                name: "veilingstukId",
                table: "Veiling",
                newName: "VeilingstukId");

            migrationBuilder.RenameIndex(
                name: "IX_Veiling_veilingstukId",
                table: "Veiling",
                newName: "IX_Veiling_VeilingstukId");

            migrationBuilder.AlterColumn<string>(
                name: "StukName",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Categorie",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Beschrijving",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Aanbieder",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "VeilingstukId",
                table: "Veiling",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiling_Veilingstuk_VeilingstukId",
                table: "Veiling",
                column: "VeilingstukId",
                principalTable: "Veilingstuk",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiling_Veilingstuk_VeilingstukId",
                table: "Veiling");

            migrationBuilder.RenameColumn(
                name: "VeilingstukId",
                table: "Veiling",
                newName: "veilingstukId");

            migrationBuilder.RenameIndex(
                name: "IX_Veiling_VeilingstukId",
                table: "Veiling",
                newName: "IX_Veiling_veilingstukId");

            migrationBuilder.AlterColumn<string>(
                name: "StukName",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Categorie",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Beschrijving",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Aanbieder",
                table: "Veilingstuk",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "veilingstukId",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiling_Veilingstuk_veilingstukId",
                table: "Veiling",
                column: "veilingstukId",
                principalTable: "Veilingstuk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
