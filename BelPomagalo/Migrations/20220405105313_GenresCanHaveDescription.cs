using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class GenresCanHaveDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Genres",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Genres");
        }
    }
}
