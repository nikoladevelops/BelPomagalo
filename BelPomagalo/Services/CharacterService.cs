using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    internal class CharacterService:Service
    {
        public CharacterService(ApplicationDbContext context) : base(context)
        {
        }
        internal IEnumerable<string> GetAllCharactersNamesOfAuthor(int authorId)
        {
            return _context.Characters
                .Where(x=>x.AuthorId==authorId)
                .Select(x => x.Name)
                .ToList();
        }
        internal Character GetCharacter(string characterName)
        {
            return _context.Characters
                .FirstOrDefault(x => x.Name == characterName);
        }
        internal Character GetCharacter(int characterId)
        {
            return _context.Characters
                .FirstOrDefault(x => x.Id == characterId);
        }
        internal async Task<Character> AddCharacter(Character character)
        {
            var addedCharacter = await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            return addedCharacter.Entity;
        }
    }
}
