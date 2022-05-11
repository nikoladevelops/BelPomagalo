using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class CharacterHasAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Characters",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Characters_AuthorId",
                table: "Characters",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characters_Authors_AuthorId",
                table: "Characters",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characters_Authors_AuthorId",
                table: "Characters");

            migrationBuilder.DropIndex(
                name: "IX_Characters_AuthorId",
                table: "Characters");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Characters");
        }
    }
}
