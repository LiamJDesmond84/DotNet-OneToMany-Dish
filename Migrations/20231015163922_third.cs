using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet_OneToMany_Dish.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "ChefId",
                table: "Dishes",
                newName: "ChefIdId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_ChefId",
                table: "Dishes",
                newName: "IX_Dishes_ChefIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefIdId",
                table: "Dishes",
                column: "ChefIdId",
                principalTable: "Chefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_Chefs_ChefIdId",
                table: "Dishes");

            migrationBuilder.RenameColumn(
                name: "ChefIdId",
                table: "Dishes",
                newName: "ChefId");

            migrationBuilder.RenameIndex(
                name: "IX_Dishes_ChefIdId",
                table: "Dishes",
                newName: "IX_Dishes_ChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_Chefs_ChefId",
                table: "Dishes",
                column: "ChefId",
                principalTable: "Chefs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
