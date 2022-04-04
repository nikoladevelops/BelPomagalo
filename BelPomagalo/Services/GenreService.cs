using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class GenreService : Service
    {
        public GenreService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<string> GetAllGenresNames()
        {
            return _context.Genres
                .Select(x => x.Name)
                .ToList();
        }

        internal Genre GetGenre(string genreName)
        {
            return _context.Genres
                .FirstOrDefault(x=>x.Name==genreName);
        }

        internal Genre GetGenre(int genreId)
        {
            return _context.Genres
                .FirstOrDefault(x => x.Id == genreId);
        }
    }
}
