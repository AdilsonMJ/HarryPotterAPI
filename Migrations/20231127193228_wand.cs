using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HarryPotterAPI.Migrations
{
    /// <inheritdoc />
    public partial class wand : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "wandid",
                table: "characters",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "wand",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Wood = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Core = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Size = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_wand", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_characters_wandid",
                table: "characters",
                column: "wandid");

            migrationBuilder.AddForeignKey(
                name: "FK_characters_wand_wandid",
                table: "characters",
                column: "wandid",
                principalTable: "wand",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_characters_wand_wandid",
                table: "characters");

            migrationBuilder.DropTable(
                name: "wand");

            migrationBuilder.DropIndex(
                name: "IX_characters_wandid",
                table: "characters");

            migrationBuilder.DropColumn(
                name: "wandid",
                table: "characters");
        }
    }
}
