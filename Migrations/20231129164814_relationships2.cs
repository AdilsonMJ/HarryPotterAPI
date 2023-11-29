using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarryPotterAPI.Migrations
{
    /// <inheritdoc />
    public partial class relationships2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsHuman",
                table: "characters",
                newName: "IsWitcher");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsWitcher",
                table: "characters",
                newName: "IsHuman");
        }
    }
}
