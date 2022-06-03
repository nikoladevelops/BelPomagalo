using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    public class GenreService : Service
    {
        public GenreService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all Genres' names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetAllGenresNames()
        {
            return _context.Genres
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets the Genre with this name.
        /// </summary>
        /// <param name="genreName">The Genre's name.</param>
        /// <returns></returns>
        public Genre GetGenre(string genreName)
        {
            return _context.Genres
                .SingleOrDefault(x=>x.Name==genreName);
        }
        /// <summary>
        /// Gets the Genre with this id.
        /// </summary>
        /// <param name="genreId">The Genre's id.</param>
        /// <returns></returns>
        public Genre GetGenre(int genreId)
        {
            return _context.Genres
                .SingleOrDefault(x => x.Id == genreId);
        }
        /// <summary>
        /// Adds a Genre.
        /// </summary>
        /// <param name="genre">The Genre to add.</param>
        /// <returns></returns>
        public async Task<Genre> AddGenre(Genre genre)
        {
            var addedGenre = await _context.Genres.AddAsync(genre);
            await _context.SaveChangesAsync();
            return addedGenre.Entity;
        }
        /// <summary>
        /// Checks if a Genre with this name already exists.
        /// </summary>
        /// <param name="genreName">The Genre's name.</param>
        /// <returns></returns>
        public bool Exists(string genreName)
        {
            return _context.Genres.SingleOrDefault(x => x.Name == genreName) != null;
        }

        /// <summary>
        /// Edits a Genre with the specified changes to apply.
        /// </summary>
        /// <param name="genre">The Genre you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the Genre.</param>
        /// <returns></returns>
        public async Task EditGenre(Genre genre, Genre changesToApply)
        {
            genre.Name = changesToApply.Name;
            genre.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }
    }
}
