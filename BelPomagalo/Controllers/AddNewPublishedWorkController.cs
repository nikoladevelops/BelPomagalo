using BelPomagalo.Models;
using BelPomagalo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Controllers
{
    internal class AddNewPublishedWorkController
    {
        private readonly ApplicationDbContext _context;
        internal readonly AuthorService _authorService;
        internal readonly GenreService _genreService;
        internal readonly ThemeService _themeService;
        internal readonly PublishedWorkService _publishedWorkService;
        internal readonly PublishedWorkGenreService _publishedWorkGenreService;
        internal readonly PublishedWorkThemeService _publishedWorkThemeService;

        internal AddNewPublishedWorkController()
        {
            _context = new ApplicationDbContext();
            _authorService = new AuthorService(_context);
            _genreService = new GenreService(_context);
            _themeService = new ThemeService(_context);
            _publishedWorkService = new PublishedWorkService(_context);
            _publishedWorkGenreService = new PublishedWorkGenreService(_context);
            _publishedWorkThemeService = new PublishedWorkThemeService(_context);
        }

        internal IEnumerable<string> GetAllAuthorNames() 
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
        internal Author GetAuthor(string authorName)
        {
            return _authorService.GetAuthor(authorName);
        }
        internal Genre GetGenre(string genreName)
        {
            return _genreService.GetGenre(genreName);
        }
        internal Theme GetTheme(string themeName)
        {
            return _themeService.GetTheme(themeName);
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

    }
}
