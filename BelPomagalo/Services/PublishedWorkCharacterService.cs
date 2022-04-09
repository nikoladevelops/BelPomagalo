using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    internal class PublishedWorkCharacterService:Service
    {
        public PublishedWorkCharacterService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<PublishedWorkCharacter> GetPublishedWorkCharacters(PublishedWork publishedWork)
        {
            return _context.PublishedWorkCharacters
                .Where(x => x.PublishedWorkId == publishedWork.Id)
                .ToList();
        }
        internal async Task<PublishedWorkCharacter> AddPublishedWorkCharacter(PublishedWorkCharacter publishedWorkCharacter)
        {
            var result = await _context.PublishedWorkCharacters.AddAsync(publishedWorkCharacter);
            await _context.SaveChangesAsync();
            return result.Entity;
        }
    }
}
