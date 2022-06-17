using BelPomagalo.Models;

namespace BelPomagalo.Services
{
    public class CharacterService:Service
    {
        public CharacterService(ApplicationDbContext context) : base(context)
        {
        }
        /// <summary>
        /// Gets all characters' names of a certain Author.
        /// </summary>
        /// <param name="authorId">The Author's id, whose Characters you want to get.</param>
        /// <returns></returns>
        public IEnumerable<string> GetAllCharactersNamesOfAuthor(int authorId)
        {
            return _context.Characters
                .Where(x => x.AuthorId == authorId)
                .Select(x => x.Name)
                .ToList();
        }
        /// <summary>
        /// Gets a Character of an Author.
        /// </summary>
        /// <param name="characterName">The Character's name.</param>
        /// <param name="authorThatOwnsCharacter">The Author that owns the Character.</param>
        /// <returns>The Character owned by the Author or NULL if no such character is owned by that author.</returns>
        public Character GetCharacter(string characterName, Author authorThatOwnsCharacter)
        {
            return _context.Characters
                .SingleOrDefault(x => x.Name == characterName && x.AuthorId == authorThatOwnsCharacter.Id);
        }
        /// <summary>
        /// Gets Character by id.
        /// </summary>
        /// <param name="characterId">The id of the Character.</param>
        /// <returns></returns>
        public Character GetCharacter(int characterId)
        {
            return _context.Characters
                .SingleOrDefault(x => x.Id == characterId);
        }
        /// <summary>
        /// Adds a Character.
        /// </summary>
        /// <param name="character">The Character to add.</param>
        /// <returns></returns>
        public async Task<Character> AddCharacter(Character character)
        {
            var addedCharacter = await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            return addedCharacter.Entity;
        }
        /// <summary>
        /// Checks if a Character is owned by an Author.
        /// </summary>
        /// <param name="characterName">The name of the Character.</param>
        /// <param name="authorThatOwnsCharacter">The Author who may or may not own the Character.</param>
        /// <returns></returns>
        public bool IsOwnedByAuthor(string characterName, Author authorThatOwnsCharacter)
        {
            var character = GetCharacter(characterName, authorThatOwnsCharacter);
            if (character != null && character.AuthorId == authorThatOwnsCharacter.Id)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Edits a Character with the specified changes to apply.
        /// </summary>
        /// <param name="character">The Character you wish to change.</param>
        /// <param name="changesToApply">The changes to apply for the Character.</param>
        /// <returns></returns>
        public async Task EditCharacter(Character character, Character changesToApply)
        {
            character.AuthorId = changesToApply.AuthorId;
            character.Name = changesToApply.Name;
            character.Description = changesToApply.Description;
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Deletes a character.
        /// </summary>
        /// <param name="character">The character to delete.</param>
        public async void Delete(Character character)
        {
            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();
        }
    }
}
