using BelPomagalo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Services
{
    internal class PublishedWorkThemeService : Service
    {
        public PublishedWorkThemeService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkTheme> GetAllPublishedWorksThemes(PublishedWork publishedWork)
        {
            return _context.PublishedWorkThemes
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal async Task<PublishedWorkTheme> AddPublishedWorkTheme(PublishedWorkTheme publishedWorkTheme)
        {
            var result = await _context.PublishedWorkThemes.AddAsync(publishedWorkTheme);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
