using BelPomagalo.Controllers.AddNewEntityControllers;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;
using BelPomagalo.Views.ShowEntityForms;

namespace BelPomagalo.Controllers
{
    internal class MainFormController:Controller<MainForm>
    {
        private readonly FormDataController _controller;
        public MainFormController(MainForm mainForm):base(mainForm)
        {
            _controller= new FormDataController();
            _form.Load += HandleFormLoad;
            _form.AuthorsListBox.SelectedIndexChanged += HandleAuthorsListBoxSelectedIndexChanged;

            _form.ShowButton.Click += HandleShowFormButtonClicked;
            _form.AddNewPublishedWorkButton.Click += HandleAddNewPublishedWorkButtonClick;
            _form.AddNewAuthorButton.Click += HandleAddNewAuthorButtonClick;
            _form.AddNewGenreButton.Click += HandleAddNewGenreButtonClick;
            _form.AddNewThemeButton.Click += HandleAddNewThemeButtonClick;
            _form.AddNewCharacterButton.Click += HandleAddNewCharacterButtonClick;
            _form.AddNewOppositionButton.Click += HandleAddNewOppositionButtonClick;
        }

        public void HandleFormLoad(object? sender, EventArgs e) 
        {
            Helper.LoadListBoxData(_form.AuthorsListBox, _controller.GetAllAuthorsNames());

            if (_form.AuthorsListBox.Items.Count > 0)
            {
                var currentSelectedAuthorName = _form.AuthorsListBox.SelectedItem.ToString();
                var author = _controller.GetAuthor(currentSelectedAuthorName);

                Helper.LoadListBoxData(_form.PublishedWorksListBox, _controller.GetPublishedWorksNames(author.Id));
            }
        }
        public void HandleShowFormButtonClicked(object? sender, EventArgs e)
        {
            var publishedWork = _controller.GetPublishedWork(_form.PublishedWorksListBox.SelectedItem.ToString());
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

            var publishedWorkForm = new ShowPublishedWorkDetailsForm(publishedWork.Name, publishedWork.Author.Name, genreNames, themeNames);
            publishedWorkForm.Show();
        }

        public void HandleAuthorsListBoxSelectedIndexChanged(object? sender, EventArgs e) 
        {
            var authorName = _form.AuthorsListBox.SelectedItem.ToString();

            var author = _controller.GetAuthor(authorName);
            Helper.LoadListBoxData(_form.PublishedWorksListBox, _controller.GetPublishedWorksNames(author.Id));
        }

        public void HandleAddNewPublishedWorkButtonClick(object? sender, EventArgs e)
        {
            new AddNewPublishedWorkFormController(new AddNewPublishedWorkForm()).Form.Show();
        }
        public void HandleAddNewAuthorButtonClick(object? sender, EventArgs e)
        {
            new AddNewAuthorFormController(new AddNewAuthorForm(), _form.AuthorsListBox).Form.Show();
        }
        public void HandleAddNewGenreButtonClick(object? sender, EventArgs e)
        {
            new AddNewGenreFormController(new AddNewGenreForm()).Form.Show();
        }
        public void HandleAddNewThemeButtonClick(object? sender, EventArgs e)
        {
            new AddNewThemeFormController(new AddNewThemeForm()).Form.Show();
        }
        public void HandleAddNewCharacterButtonClick(object? sender, EventArgs e)
        {
            new AddNewCharacterFormController(new AddNewCharacterForm()).Form.Show();
        }
        public void HandleAddNewOppositionButtonClick(object? sender, EventArgs e)
        {
            new AddNewOppositionFormController(new AddNewOppositionForm()).Form.Show();
        }
    }
}
