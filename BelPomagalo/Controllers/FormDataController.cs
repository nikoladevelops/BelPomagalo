using BelPomagalo.Models;
using BelPomagalo.Services;
using Microsoft.EntityFrameworkCore;

namespace BelPomagalo.Controllers
{
    internal class FormDataController
    {
        private readonly ApplicationDbContext _context;
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly ThemeService _themeService;
        private readonly CharacterService _characterService;
        private readonly OppositionService _oppositionService;
        private readonly PublishedWorkService _publishedWorkService;
        private readonly PublishedWorkGenreService _publishedWorkGenreService;
        private readonly PublishedWorkThemeService _publishedWorkThemeService;
        private readonly PublishedWorkCharacterService _publishedWorkCharacterService;
        private readonly PublishedWorkOppositionService _publishedWorkOppositionService;

        internal FormDataController()
        {
            _context = new ApplicationDbContext();
            _context.Database.Migrate();

            _authorService = new AuthorService(_context);
            _genreService = new GenreService(_context);
            _themeService = new ThemeService(_context);
            _characterService = new CharacterService(_context);
            _oppositionService = new OppositionService(_context);
            _publishedWorkService = new PublishedWorkService(_context);
            _publishedWorkGenreService = new PublishedWorkGenreService(_context);
            _publishedWorkThemeService = new PublishedWorkThemeService(_context);
            _publishedWorkCharacterService = new PublishedWorkCharacterService(_context);
            _publishedWorkOppositionService= new PublishedWorkOppositionService(_context);

        }

        internal IEnumerable<string> GetAllAuthorsNames() 
        {
            return _authorService.GetAllAuthorsNames();
        }
        internal IEnumerable<string> GetAllGenresNames() 
        {
            return _genreService.GetAllGenresNames();
        }
        internal IEnumerable<string> GetAllThemesNames()
        {
            return _themeService.GetAllThemesNames();
        }
        internal IEnumerable<string> GetPublishedWorksNames(int authorId)
        {
            return _publishedWorkService.GetPublishedWorksNames(authorId);
        }
        internal Author GetAuthor(string authorName)
        {
            return _authorService.GetAuthor(authorName);
        }
        internal Genre GetGenre(string genreName)
        {
            return _genreService.GetGenre(genreName);
        }
        internal Genre GetGenre(int genreId)
        {
            return _genreService.GetGenre(genreId);
        }
        internal Theme GetTheme(string themeName)
        {
            return _themeService.GetTheme(themeName);
        }
        internal Theme GetTheme(int themeId)
        {
            return _themeService.GetTheme(themeId);
        }
        internal Character GetCharacter(int characterId) 
        {
            return _characterService.GetCharacter(characterId); 
        }
        internal Character GetCharacter(string characterName)
        {
            return _characterService.GetCharacter(characterName);
        }
        internal IEnumerable<string> GetCharactersNamesOfAuthor(int authorId)
        {
            return _characterService.GetAllCharactersNamesOfAuthor(authorId);
        }
        internal Opposition GetOpposition(string oppositionName)
        {
            return _oppositionService.GetOpposition(oppositionName);
        }
        internal Opposition GetOpposition(int oppositionId)
        {
            return _oppositionService.GetOpposition(oppositionId);
        }
        internal IEnumerable<string> GetAllOppositionsNames()
        {
            return _oppositionService.GetAllOppositionsNames();
        }
        internal PublishedWork GetPublishedWork(string publishedWorkName)
        {
            return _publishedWorkService.GetPublishedWork(publishedWorkName);
        }
        internal IEnumerable<PublishedWorkGenre> GetPublishedWorksGenres(PublishedWork publishedWork)
        {
            return _publishedWorkGenreService.GetPublishedWorksGenres(publishedWork);
        }
        internal IEnumerable<PublishedWorkTheme> GetPublishedWorksThemes(PublishedWork publishedWork)
        {
            return _publishedWorkThemeService.GetPublishedWorksThemes(publishedWork);
        }
        internal IEnumerable<PublishedWorkCharacter> GetPublishedWorkCharacters(PublishedWork publishedWork)
        {
            return _publishedWorkCharacterService.GetPublishedWorkCharacters(publishedWork);
        }
        internal IEnumerable<PublishedWorkOpposition> GetPublishedWorksOppositions(PublishedWork publishedWork)
        {
            return _publishedWorkOppositionService.GetPublishedWorksOppositions(publishedWork);
        }
        internal async Task<Theme> AddTheme(Theme theme)
        {
            return await _themeService.AddTheme(theme);
        }
        internal async Task<Genre> AddGenre(Genre genre)
        {
            return await _genreService.AddGenre(genre);
        }
        internal async Task<Author> AddAuthor(Author author)
        {
            return await _authorService.AddAuthor(author);
        }
        internal async Task<Character> AddCharacter(Character character)
        {
            return await _characterService.AddCharacter(character);
        }
        internal async Task<PublishedWork> AddPublishedWork(PublishedWork publishedWork)
        {
            return await _publishedWorkService.AddPublishedWork(publishedWork);
        }
        internal async Task<PublishedWorkGenre> AddPublishedWorkGenre(PublishedWorkGenre publishedWorkGenre)
        {
            return await _publishedWorkGenreService.AddPublishedWorkGenre(publishedWorkGenre);
        }
        internal async Task<PublishedWorkTheme> AddPublishedWorkTheme(PublishedWorkTheme publishedWorkTheme)
        {
            return await _publishedWorkThemeService.AddPublishedWorkTheme(publishedWorkTheme);
        }
        internal async Task<PublishedWorkCharacter> AddPublishedWorkCharacter(PublishedWorkCharacter publishedWorkCharacter)
        {
            return await _publishedWorkCharacterService.AddPublishedWorkCharacter(publishedWorkCharacter);
        }
        internal async Task<PublishedWorkOpposition> AddPublishedWorkOpposition(PublishedWorkOpposition publishedWorkOpposition)
        {
            return await _publishedWorkOppositionService.AddPublishedWorkOpposition(publishedWorkOpposition);
        }

    }
}
