using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelPomagalo.Views
{
    public partial class AddNewPublishedWork : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly ThemeService _themeService;
        private readonly PublishedWorkService _publishedWorkService;
        public AddNewPublishedWork()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _authorService = new AuthorService(_context);
            _genreService = new GenreService(_context);
            _themeService = new ThemeService(_context);
            _publishedWorkService = new PublishedWorkService(_context);

            Helper.LoadListBoxData(authorListBox, _authorService.GetAllAuthorsNames());
            Helper.LoadListBoxData(genreListBox, _genreService.GetAllGenresNames());
            Helper.LoadListBoxData(themeListBox, _themeService.GetAllThemesNames());
        }

        private async void addPublishedWorkButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var author = _authorService.GetAuthor(authorListBox.SelectedItem.ToString());


            var genres = new List<Genre>();
            foreach (var selectedItem in genreListBox.SelectedItems)
            {
                var selectedGenre = _genreService.GetGenre(selectedItem.ToString());
                genres.Add(selectedGenre);
            }

            var themes = new List<Theme>();
            foreach (var selectedItem in themeListBox.SelectedItems)
            {
                var selectedTheme = _themeService.GetTheme(selectedItem.ToString());
                themes.Add(selectedTheme);
            }

            var publishedWork = new PublishedWork()
            {
                Name=name,
                AuthorId=author.Id
            };

            publishedWork = await _publishedWorkService.AddPublishedWork(publishedWork);

            foreach (var genre in genres)
            {
                _context.PublishedWorkGenres.Add(new PublishedWorkGenre() { PublishedWorkId = publishedWork.Id, GenreId = genre.Id });

            }

            foreach (var theme in themes)
            {
                _context.PublishedWorkThemes.Add(new PublishedWorkTheme() { PublishedWorkId = publishedWork.Id, ThemeId = theme.Id });
            }

            await _context.SaveChangesAsync();
        }
    }
}
