using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    internal class PublishedWorkOppositionService : Service
    {
        public PublishedWorkOppositionService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkOpposition> GetPublishedWorksOppositions(PublishedWork publishedWork)
        {
            return _context.PublishedWorkOppositions
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal async Task<PublishedWorkOpposition> AddPublishedWorkOpposition(PublishedWorkOpposition publishedWorkOpposition)
        {
            var result = await _context.PublishedWorkOppositions.AddAsync(publishedWorkOpposition);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
