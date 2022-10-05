using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace la_mia_pizzeria_post.Migrations
{
    public partial class ChangeTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza");

            migrationBuilder.RenameTable(
                name: "Pizza",
                newName: "Pizze");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizze",
                table: "Pizze",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Pizze",
                table: "Pizze");

            migrationBuilder.RenameTable(
                name: "Pizze",
                newName: "Pizza");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pizza",
                table: "Pizza",
                column: "Id");
        }
    }
}
