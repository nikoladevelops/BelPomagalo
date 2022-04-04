using BelPomagalo.Models;
using BelPomagalo.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Controllers
{
    internal class FormDataController
    {
        private readonly ApplicationDbContext _context;
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly ThemeService _themeService;
        private readonly PublishedWorkService _publishedWorkService;
        private readonly PublishedWorkGenreService _publishedWorkGenreService;
        private readonly PublishedWorkThemeService _publishedWorkThemeService;

        internal FormDataController()
        {
            _context = new ApplicationDbContext();
            _context.Database.Migrate();

            _authorService = new AuthorService(_context);
            _genreService = new GenreService(_context);
            _themeService = new ThemeService(_context);
            _publishedWorkService = new PublishedWorkService(_context);
            _publishedWorkGenreService = new PublishedWorkGenreService(_context);
            _publishedWorkThemeService = new PublishedWorkThemeService(_context);
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
