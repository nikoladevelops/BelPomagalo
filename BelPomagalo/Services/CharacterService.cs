using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    internal class CharacterService:Service
    {
        public CharacterService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all characters' names of a certain author.
        /// </summary>
        /// <param name="authorId">The author's id, whose characters you want to get.</param>
        /// <returns></returns>
        internal IEnumerable<string> GetAllCharactersNamesOfAuthor(int authorId)
        {
            return _context.Characters
                .Where(x => x.AuthorId == authorId)
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Get the first found character with the specified name.
        /// </summary>
        /// <param name="characterName">The character's name</param>
        /// <returns></returns>
        internal Character GetCharacter(string characterName)
        {
            return _context.Characters
                .FirstOrDefault(x => x.Name == characterName);
        }
        /// <summary>
        /// Get a character of an Author.
        /// </summary>
        /// <param name="characterName">The character name.</param>
        /// <param name="authorThatOwnsCharacter">The author that owns the character.</param>
        /// <returns>The character owned by the author or NULL if no such character is owned by that author.</returns>
        internal Character GetCharacter(string characterName, Author authorThatOwnsCharacter)
        {
            return _context.Characters
                .SingleOrDefault(x => x.Name == characterName && x.AuthorId == authorThatOwnsCharacter.Id);
        }
        /// <summary>
        /// Get character by id.
        /// </summary>
        /// <param name="characterId">The id of the character.</param>
        /// <returns></returns>
        internal Character GetCharacter(int characterId)
        {
            return _context.Characters
                .SingleOrDefault(x => x.Id == characterId);
        }
        /// <summary>
        /// Add a character.
        /// </summary>
        /// <param name="character">The character to add.</param>
        /// <returns></returns>
        internal async Task<Character> AddCharacter(Character character)
        {
            var addedCharacter = await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            return addedCharacter.Entity;
        }
        /// <summary>
        /// Check if a character is owned by an author.
        /// </summary>
        /// <param name="characterName"></param>
        /// <param name="authorThatOwnsCharacter"></param>
        /// <returns></returns>
        internal bool IsOwnedByAuthor(string characterName, Author authorThatOwnsCharacter)
        {
            var character = GetCharacter(characterName, authorThatOwnsCharacter);
            if (character != null && character.AuthorId == authorThatOwnsCharacter.Id)
            {
                return true;
            }
            return false;
        }
    }
}
