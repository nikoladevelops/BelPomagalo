using BelPomagalo.Utility;
using BelPomagalo.Views;

namespace BelPomagalo.Controllers
{
    internal class MainFormController
    {
        private readonly FormDataController _controller;
        private readonly MainForm _mainForm;
        private readonly AddNewPublishedWorkForm _addNewPublishedWorkForm;
        private readonly AddNewAuthorForm _addNewAuthorForm;
        private readonly AddNewGenreForm _addNewGenreForm;
        private readonly AddNewThemeForm _addNewThemeForm;
        public MainFormController(MainForm mainForm, AddNewPublishedWorkForm publishedWorkForm,
            AddNewAuthorForm authorForm, AddNewGenreForm genreForm, AddNewThemeForm themeForm)
        {
            _controller= new FormDataController();
            _mainForm = mainForm;
            _addNewPublishedWorkForm = publishedWorkForm;
            _addNewAuthorForm = authorForm;
            _addNewGenreForm = genreForm;
            _addNewThemeForm = themeForm;

            _mainForm.Load += HandleFormLoad;
            _mainForm.AuthorsListBox.SelectedIndexChanged += HandleAuthorsListBoxSelectedIndexChanged;

            _mainForm.ShowButton.Click += HandleShowFormButtonClicked;
            _mainForm.AddNewPublishedWorkButton.Click += HandleAddNewPublishedWorkButtonClick;
            _mainForm.AddNewAuthorButton.Click += HandleAddNewAuthorButtonClick;
            _mainForm.AddNewGenreButton.Click += HandleAddNewGenreButtonClick;
            _mainForm.AddNewThemeButton.Click += HandleAddNewThemeButtonClick;
        }

        public MainForm Form { get => _mainForm; }
        public void HandleFormLoad(object? sender, EventArgs e) 
        {
            Helper.LoadListBoxData(_mainForm.AuthorsListBox, _controller.GetAllAuthorsNames());

            if (_mainForm.AuthorsListBox.Items.Count > 0)
            {
                var currentSelectedAuthorName = _mainForm.AuthorsListBox.SelectedItem.ToString();
                var author = _controller.GetAuthor(currentSelectedAuthorName);

                Helper.LoadListBoxData(_mainForm.PublishedWorksListBox, _controller.GetPublishedWorksNames(author.Id));
            }
        }
        public void HandleShowFormButtonClicked(object? sender, EventArgs e)
        {
            var publishedWork = _controller.GetPublishedWork(_mainForm.PublishedWorksListBox.SelectedItem.ToString());
            var publishedWorkGenres = _controller.GetPublishedWorksGenres(publishedWork);
            var publishedWorkThemes = _controller.GetPublishedWorksThemes(publishedWork);

            var genreNames = new List<string>();
            foreach (var workGenre in publishedWorkGenres)
            {
                var pwGenre = _controller.GetGenre(workGenre.GenreId);
                genreNames.Add(pwGenre.Name);
            }

            var themeNames = new List<string>();
            foreach (var workTheme in publishedWorkThemes)
            {
                var pwTheme = _controller.GetTheme(workTheme.ThemeId);
                themeNames.Add(pwTheme.Name);
            }

            var publishedWorkForm = new ShowPublishedWorkDetails(publishedWork.Name, publishedWork.Author.Name, genreNames, themeNames);
            publishedWorkForm.Show();
        }

        public void HandleAuthorsListBoxSelectedIndexChanged(object? sender, EventArgs e) 
        {
            var authorName = _mainForm.AuthorsListBox.SelectedItem.ToString();

            var author = _controller.GetAuthor(authorName);
            Helper.LoadListBoxData(_mainForm.PublishedWorksListBox, _controller.GetPublishedWorksNames(author.Id));
        }

        public void HandleAddNewPublishedWorkButtonClick(object? sender, EventArgs e)
        {
            _addNewPublishedWorkForm.Show();
        }
        public void HandleAddNewAuthorButtonClick(object? sender, EventArgs e)
        {
            _addNewAuthorForm.Show();
        }
        public void HandleAddNewGenreButtonClick(object? sender, EventArgs e)
        {
            _addNewGenreForm.Show();
        }
        public void HandleAddNewThemeButtonClick(object? sender, EventArgs e)
        {
            _addNewThemeForm.Show();
        }

    }
}
