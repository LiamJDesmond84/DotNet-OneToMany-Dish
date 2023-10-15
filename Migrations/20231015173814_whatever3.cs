﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DotNet_OneToMany_Dish.Migrations
{
    /// <inheritdoc />
    public partial class whatever3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "selectedValue",
                table: "Dishes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "selectedValue",
                table: "Dishes");
        }
    }
}
