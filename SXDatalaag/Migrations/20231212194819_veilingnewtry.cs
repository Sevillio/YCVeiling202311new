using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class veilingnewtry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veilingstuk_Account_AccountId",
                table: "Veilingstuk");

            migrationBuilder.DropIndex(
                name: "IX_Veilingstuk_AccountId",
                table: "Veilingstuk");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Veilingstuk");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Veilingstuk",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Veilingstuk_AccountId",
                table: "Veilingstuk",
                column: "AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veilingstuk_Account_AccountId",
                table: "Veilingstuk",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
