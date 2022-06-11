using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var currentDir = Path.GetDirectoryName(Application.ExecutablePath);
            var connectionString = "Data Source=" + currentDir + "\\DataStore\\PomagaloData.db";
            optionsBuilder.UseSqlite(connectionString);
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PublishedWork> PublishedWorks { get; set; }
        public DbSet<Theme> Themes { get; set; }
        public DbSet<Opposition> Oppositions { get; set; }
        public DbSet<PublishedWorkGenre> PublishedWorkGenres { get; set; }
        public DbSet<PublishedWorkTheme> PublishedWorkThemes { get; set; }
        public DbSet<PublishedWorkCharacter> PublishedWorkCharacters { get; set; }
        public DbSet<PublishedWorkOpposition> PublishedWorkOppositions { get; set; }

        public DbSet<GrammarRule> GrammarRules { get; set; }
        public DbSet<WritingRule> WritingRules { get; set; }
        public DbSet<PunctuationRule> PunctuationRules { get; set; }
        public DbSet<QuestionChlenuvane> QuestionsChlenuvane { get; set; }
    }
}
