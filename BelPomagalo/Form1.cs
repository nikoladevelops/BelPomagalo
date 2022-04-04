using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using Microsoft.EntityFrameworkCore;

namespace BelPomagalo
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly AuthorService _authorService;
        private readonly PublishedWorkService _publishedWorkService;
        private readonly GenreService _genreService;
        private readonly ThemeService _themeService;
        public Form1()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _context.Database.Migrate();

            _authorService = new AuthorService(_context);
            _publishedWorkService = new PublishedWorkService(_context);
            _genreService = new GenreService(_context);
            _themeService = new ThemeService(_context);

            Helper.LoadListBoxData(authorsListBox, _authorService.GetAllAuthorsNames());

            if (authorsListBox.Items.Count>0)
            {
                var currentSelectedAuthorName = authorsListBox.SelectedItem.ToString();
                var author = _authorService.GetAuthor(currentSelectedAuthorName);

                Helper.LoadListBoxData(publishedWorkListBox, _publishedWorkService.GetPublishedWorksNames(author.Id));
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var publishedWork = _publishedWorkService.GetPublishedWork(publishedWorkListBox.SelectedItem.ToString());
            var publishedWorkGenres = _context.PublishedWorkGenres.Where(x => x.PublishedWorkId == publishedWork.Id).ToList();
            var publishedWorkThemes = _context.PublishedWorkThemes.Where(x => x.PublishedWorkId == publishedWork.Id).ToList();

            var genreNames = new List<string>();
            foreach (var workGenre in publishedWorkGenres)
            {
                var pwGenre = _genreService.GetGenre(workGenre.GenreId);
                genreNames.Add(pwGenre.Name);
            }

            var themeNames = new List<string>();
            foreach (var workTheme in publishedWorkThemes)
            {
                var pwTheme = _themeService.GetTheme(workTheme.ThemeId);
                themeNames.Add(pwTheme.Name);
            }

            var publishedWorkForm = new ShowPublishedWorkDetails(publishedWork.Name, publishedWork.Author.Name, genreNames, themeNames);
            publishedWorkForm.Show();
        }

        private void SelectedAuthorChanged(object sender, EventArgs e)
        {
            var authorName = ((ListBox)sender).SelectedItem.ToString();
            
            var author = _authorService.GetAuthor(authorName);
            Helper.LoadListBoxData(publishedWorkListBox,_publishedWorkService.GetPublishedWorksNames(author.Id));
        }

        private void addNewPublishedWorkButton_Click(object sender, EventArgs e)
        {
            var addNewPublishedWorkForm = new AddNewPublishedWork();
            addNewPublishedWorkForm.Show();
        }
    }
}