using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class PublishedWorkHasManyOppositions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Oppositions",
                table: "PublishedWorks");

            migrationBuilder.CreateTable(
                name: "Oppositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oppositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PublishedWorkOppositions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PublishedWorkId = table.Column<int>(type: "INTEGER", nullable: false),
                    OppositionId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PublishedWorkOppositions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PublishedWorkOppositions_Oppositions_OppositionId",
                        column: x => x.OppositionId,
                        principalTable: "Oppositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PublishedWorkOppositions_PublishedWorks_PublishedWorkId",
                        column: x => x.PublishedWorkId,
                        principalTable: "PublishedWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorkOppositions_OppositionId",
                table: "PublishedWorkOppositions",
                column: "OppositionId");

            migrationBuilder.CreateIndex(
                name: "IX_PublishedWorkOppositions_PublishedWorkId",
                table: "PublishedWorkOppositions",
                column: "PublishedWorkId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PublishedWorkOppositions");

            migrationBuilder.DropTable(
                name: "Oppositions");

            migrationBuilder.AddColumn<string>(
                name: "Oppositions",
                table: "PublishedWorks",
                type: "TEXT",
                nullable: true);
        }
    }
}
