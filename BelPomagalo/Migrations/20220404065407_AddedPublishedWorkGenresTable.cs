using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class AddedPublishedWorkGenresTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PublishedWorks_Genres_GenreId",
                table: "PublishedWorks");

            migrationBuilder.DropIndex(
                name: "IX_PublishedWorks_GenreId",
                table: "PublishedWorks");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "PublishedWorks");

            migrationBuilder.CreateTable(
                name: "PublishedWorkGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GenreId = table.Column<int>(type: "INTEGER", nullable: false),
                    PublishedWorkId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishedWorkGenres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublishedWorkGenres_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublishedWorkGenres_PublishedWorks_PublishedWorkId",
                        column: x => x.PublishedWorkId,
                        principalTable: "PublishedWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorkGenres_GenreId",
                table: "PublishedWorkGenres",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorkGenres_PublishedWorkId",
                table: "PublishedWorkGenres",
                column: "PublishedWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublishedWorkGenres");

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "PublishedWorks",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorks_GenreId",
                table: "PublishedWorks",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_PublishedWorks_Genres_GenreId",
                table: "PublishedWorks",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
