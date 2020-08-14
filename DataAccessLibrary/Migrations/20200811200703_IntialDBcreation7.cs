using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLibrary.Migrations
{
    public partial class IntialDBcreation7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_People_OwnerIDPersonID",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_OwnerIDPersonID",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "OwnerIDPersonID",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "PersonID1",
                table: "Carts",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_PersonID1",
                table: "Carts",
                column: "PersonID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_People_PersonID1",
                table: "Carts",
                column: "PersonID1",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_People_PersonID1",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_PersonID1",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "PersonID1",
                table: "Carts");

            migrationBuilder.AddColumn<int>(
                name: "OwnerIDPersonID",
                table: "Carts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Carts_OwnerIDPersonID",
                table: "Carts",
                column: "OwnerIDPersonID");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_People_OwnerIDPersonID",
                table: "Carts",
                column: "OwnerIDPersonID",
                principalTable: "People",
                principalColumn: "PersonID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
