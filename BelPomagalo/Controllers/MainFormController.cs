using BelPomagalo.Controllers.AddNewEntityControllers;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;
using BelPomagalo.Views.ShowEntityForms;

namespace BelPomagalo.Controllers
{
    internal class MainFormController:Controller<MainForm>
    {
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

        private Button activeButton;
        private Form activeForm;

        public MainFormController(MainForm mainForm, AuthorService authorService, GenreService genreService, ThemeService themeService,
            CharacterService characterService, OppositionService oppositionService, PublishedWorkService publishedWorkService,
            PublishedWorkGenreService publishedWorkGenreService, PublishedWorkThemeService publishedWorkThemeService,
            PublishedWorkCharacterService publishedWorkCharacterService, PublishedWorkOppositionService publishedWorkOppositionService):base(mainForm)
        {
            _authorService = authorService;
            _genreService = genreService;
            _themeService = themeService;
            _characterService = characterService;
            _oppositionService = oppositionService;
            _publishedWorkService = publishedWorkService;
            _publishedWorkGenreService = publishedWorkGenreService;
            _publishedWorkThemeService = publishedWorkThemeService;
            _publishedWorkCharacterService = publishedWorkCharacterService;
            _publishedWorkOppositionService = publishedWorkOppositionService;

            _form.HomeMenuButton.Click += MakeMenuButtonActiveOnClick;
            _form.GamesMenuButton.Click += MakeMenuButtonActiveOnClick;
            _form.LibraryMenuButton.Click += MakeMenuButtonActiveOnClick;

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

        private void MakeMenuButtonActiveOnClick(object? sender, EventArgs e)
        {
            if (activeButton != null) 
            {
                activeButton.BackColor = Color.FromArgb(241, 144, 102);
            }
            activeButton = sender as Button;
            activeButton.BackColor= Color.FromArgb(231, 127, 103);

            Form formToMakeActive = null;
            switch (activeButton.Name)
            {
                case "homeMenuButton":
                    formToMakeActive = new HomeForm();
                    break;
                case "gamesMenuButton":
                    formToMakeActive = new GamesForm();
                    break;
                case "libraryMenuButton":
                    formToMakeActive = new LibraryForm();
                    break;
                default:
                    break;
            }
            MakeFormActive(formToMakeActive);
        }
        private void MakeFormActive(Form childForm)
        {
            if (activeForm != null) 
            {
                // no need to load the form again, if we are trying to load the same form
                if (childForm.Name == activeForm.Name)
                {
                    return;
                }
                // make sure the old form is closed and doesn't use any resources
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            _form.ContentPanel.Controls.Clear(); // just in case, remove any elements in the content panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            _form.ContentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
        public void HandleFormLoad(object? sender, EventArgs e) 
        {
            Helper.LoadListBoxData(_form.AuthorsListBox, _authorService.GetAllAuthorsNames());

            if (_form.AuthorsListBox.Items.Count > 0)
            {
                var currentSelectedAuthorName = _form.AuthorsListBox.SelectedItem.ToString();
                var author = _authorService.GetAuthor(currentSelectedAuthorName);

                Helper.LoadListBoxData(_form.PublishedWorksListBox, _publishedWorkService.GetPublishedWorksNames(author.Id));
            }
        }
        public void HandleShowFormButtonClicked(object? sender, EventArgs e)
        {
            var publishedWork = _publishedWorkService.GetPublishedWork(_form.PublishedWorksListBox.SelectedItem.ToString());
            var publishedWorkGenres = _publishedWorkGenreService.GetPublishedWorksGenres(publishedWork);
            var publishedWorkThemes = _publishedWorkThemeService.GetPublishedWorksThemes(publishedWork);

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

            var publishedWorkForm = new ShowPublishedWorkDetailsForm(publishedWork.Name, publishedWork.Author.Name, genreNames, themeNames);
            publishedWorkForm.Show();
        }

        public void HandleAuthorsListBoxSelectedIndexChanged(object? sender, EventArgs e) 
        {
            var authorName = _form.AuthorsListBox.SelectedItem.ToString();

            var author = _authorService.GetAuthor(authorName);
            Helper.LoadListBoxData(_form.PublishedWorksListBox, _publishedWorkService.GetPublishedWorksNames(author.Id));
        }

        public void HandleAddNewPublishedWorkButtonClick(object? sender, EventArgs e)
        {
            new AddNewPublishedWorkFormController(new AddNewPublishedWorkForm(),
                _authorService,
                _genreService,
                _themeService,
                _characterService,
                _oppositionService,
                _publishedWorkService,
                _publishedWorkGenreService,
                _publishedWorkThemeService,
                _publishedWorkCharacterService,
                _publishedWorkOppositionService).Form.Show();
        }
        public void HandleAddNewAuthorButtonClick(object? sender, EventArgs e)
        {
            new AddNewAuthorFormController(new AddNewAuthorForm(),
                _form.AuthorsListBox,
                _authorService).Form.Show();
        }
        public void HandleAddNewGenreButtonClick(object? sender, EventArgs e)
        {
            new AddNewGenreFormController(new AddNewGenreForm(),
                _genreService).Form.Show();
        }
        public void HandleAddNewThemeButtonClick(object? sender, EventArgs e)
        {
            new AddNewThemeFormController(new AddNewThemeForm(),
                _themeService).Form.Show();
        }
        public void HandleAddNewCharacterButtonClick(object? sender, EventArgs e)
        {
            new AddNewCharacterFormController(new AddNewCharacterForm(),
                _characterService, _authorService).Form.Show();
        }
        public void HandleAddNewOppositionButtonClick(object? sender, EventArgs e)
        {
            new AddNewOppositionFormController(new AddNewOppositionForm(),
                _oppositionService).Form.Show();
        }
    }
}
