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
    }
}
