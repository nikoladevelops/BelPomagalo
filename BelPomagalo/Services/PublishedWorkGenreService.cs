using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class PublishedWorkGenreService : Service
    {
        public PublishedWorkGenreService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkGenre> GetPublishedWorksGenres(PublishedWork publishedWork)
        {
            return _context.PublishedWorkGenres
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal async Task<PublishedWorkGenre> AddPublishedWorkGenre(PublishedWorkGenre publishedWorkGenre)
        {
            var result = await _context.PublishedWorkGenres.AddAsync(publishedWorkGenre);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
