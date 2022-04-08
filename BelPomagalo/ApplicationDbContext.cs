using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo
{
    internal class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=PomagaloData.db");
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
    }
}
