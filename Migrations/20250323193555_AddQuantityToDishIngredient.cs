using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuAppBlazor.Migrations
{
    /// <inheritdoc />
    public partial class AddQuantityToDishIngredient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Quantity",
                table: "DishIngredients",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "QuantityType",
                table: "DishIngredients",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "DishIngredients");

            migrationBuilder.DropColumn(
                name: "QuantityType",
                table: "DishIngredients");
        }
    }
}
