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
    }
}
