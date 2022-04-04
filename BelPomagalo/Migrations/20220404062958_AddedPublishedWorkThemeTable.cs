using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class AddedPublishedWorkThemeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublishedWorks_Themes_ThemeId",
                table: "PublishedWorks");

            migrationBuilder.DropIndex(
                name: "IX_PublishedWorks_ThemeId",
                table: "PublishedWorks");

            migrationBuilder.DropColumn(
                name: "ThemeId",
                table: "PublishedWorks");

            migrationBuilder.CreateTable(
                name: "PublishedWorkThemes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ThemeId = table.Column<int>(type: "INTEGER", nullable: false),
                    PublishedWorkId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishedWorkThemes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublishedWorkThemes_PublishedWorks_PublishedWorkId",
                        column: x => x.PublishedWorkId,
                        principalTable: "PublishedWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublishedWorkThemes_Themes_ThemeId",
                        column: x => x.ThemeId,
                        principalTable: "Themes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorkThemes_PublishedWorkId",
                table: "PublishedWorkThemes",
                column: "PublishedWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorkThemes_ThemeId",
                table: "PublishedWorkThemes",
                column: "ThemeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublishedWorkThemes");

            migrationBuilder.AddColumn<int>(
                name: "ThemeId",
                table: "PublishedWorks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorks_ThemeId",
                table: "PublishedWorks",
                column: "ThemeId");

            migrationBuilder.AddForeignKey(
                name: "FK_PublishedWorks_Themes_ThemeId",
                table: "PublishedWorks",
                column: "ThemeId",
                principalTable: "Themes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
