using BelPomagalo.Models;
using Microsoft.EntityFrameworkCore;

namespace BelPomagalo.Services
{
    internal class PublishedWorkOppositionService : Service
    {
        public PublishedWorkOppositionService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkOpposition> GetPublishedWorkOppositions(PublishedWork publishedWork)
        {
            return _context.PublishedWorkOppositions
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal IEnumerable<string> GetPublishedWorkOppositionsNames(PublishedWork publishedWork)
        {
            return _context.PublishedWorkOppositions
                .Include(x => x.Opposition)
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .Select(x => x.Opposition.Name)
                .ToList();
        }
        internal async Task<PublishedWorkOpposition> AddPublishedWorkOpposition(PublishedWorkOpposition publishedWorkOpposition)
        {
            var result = await _context.PublishedWorkOppositions.AddAsync(publishedWorkOpposition);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        internal async Task ChangeOppositions(PublishedWork publishedWork, IEnumerable<Opposition> newOppositions)
        {
            var publishedWorkOppositions = _context.PublishedWorkOppositions
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();

            _context.PublishedWorkOppositions.RemoveRange(publishedWorkOppositions);
            foreach (var opposition in newOppositions)
            {
                await _context.PublishedWorkOppositions
                    .AddAsync(new PublishedWorkOpposition()
                    { PublishedWorkId = publishedWork.Id, OppositionId = opposition.Id });

            }
            await _context.SaveChangesAsync();
        }
    }
}
