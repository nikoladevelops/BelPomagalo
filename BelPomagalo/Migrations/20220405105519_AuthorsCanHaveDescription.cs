using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class AuthorsCanHaveDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Authors",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Authors");
        }
    }
}
