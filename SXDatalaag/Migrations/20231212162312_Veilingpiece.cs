using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SXDatalaag.Migrations
{
    public partial class Veilingpiece : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiling_Veilingstuk_VeilingstukId",
                table: "Veiling");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Veilingstuk",
                newName: "StukName");

            migrationBuilder.AddColumn<int>(
                name: "AccountId",
                table: "Veilingstuk",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "VeilingstukId",
                table: "Veiling",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefoon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Bod",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Prijs = table.Column<int>(type: "int", nullable: false),
                    AccountId = table.Column<int>(type: "int", nullable: false),
                    VeilingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bod", x => x.id);
                    table.ForeignKey(
                        name: "FK_Bod_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bod_Veiling_VeilingId",
                        column: x => x.VeilingId,
                        principalTable: "Veiling",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veilingstuk_AccountId",
                table: "Veilingstuk",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bod_AccountId",
                table: "Bod",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_Bod_VeilingId",
                table: "Bod",
                column: "VeilingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiling_Veilingstuk_VeilingstukId",
                table: "Veiling",
                column: "VeilingstukId",
                principalTable: "Veilingstuk",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veilingstuk_Account_AccountId",
                table: "Veilingstuk",
                column: "AccountId",
                principalTable: "Account",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiling_Veilingstuk_VeilingstukId",
                table: "Veiling");

            migrationBuilder.DropForeignKey(
                name: "FK_Veilingstuk_Account_AccountId",
                table: "Veilingstuk");

            migrationBuilder.DropTable(
                name: "Bod");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropIndex(
                name: "IX_Veilingstuk_AccountId",
                table: "Veilingstuk");

            migrationBuilder.DropColumn(
                name: "AccountId",
                table: "Veilingstuk");

            migrationBuilder.RenameColumn(
                name: "StukName",
                table: "Veilingstuk",
                newName: "Name");

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
    }
}
