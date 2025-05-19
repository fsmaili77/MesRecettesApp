using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MesRecettes.Migrations
{
    public partial class RecetteModif : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecetteId",
                table: "Ingredients",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ingredients_RecetteId",
                table: "Ingredients",
                column: "RecetteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ingredients_Recettes_RecetteId",
                table: "Ingredients",
                column: "RecetteId",
                principalTable: "Recettes",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ingredients_Recettes_RecetteId",
                table: "Ingredients");

            migrationBuilder.DropIndex(
                name: "IX_Ingredients_RecetteId",
                table: "Ingredients");

            migrationBuilder.DropColumn(
                name: "RecetteId",
                table: "Ingredients");
        }
    }
}
