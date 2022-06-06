using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelPomagalo.Migrations
{
    public partial class AddedQuestionChlenuvaneModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionsChlenuvane",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Sentence = table.Column<string>(type: "TEXT", nullable: false),
                    CorrectSentence = table.Column<string>(type: "TEXT", nullable: false),
                    CorrectAnswers = table.Column<string>(type: "TEXT", nullable: false),
                    WrongAnswers = table.Column<string>(type: "TEXT", nullable: false),
                    CountAnswers = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionsChlenuvane", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionsChlenuvane");
        }
    }
}
