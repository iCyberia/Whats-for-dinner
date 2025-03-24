using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MenuAppBlazor.Migrations
{
    /// <inheritdoc />
    public partial class RemoveAddedOnFromUpcomingMenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedOn",
                table: "UpcomingMenu");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AddedOn",
                table: "UpcomingMenu",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
