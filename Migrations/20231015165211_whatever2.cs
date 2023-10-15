using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet_OneToMany_Dish.Migrations
{
    /// <inheritdoc />
    public partial class whatever2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Chefs",
                newName: "ChefId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ChefId",
                table: "Chefs",
                newName: "Id");
        }
    }
}
