using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarryPotterAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsHuman",
                table: "characters",
                type: "tinyint(1)",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsHuman",
                table: "characters");
        }
    }
}
