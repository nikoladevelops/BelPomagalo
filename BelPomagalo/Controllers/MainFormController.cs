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

            // set the default form that is loaded in the content panel to be HomeForm
            activeButton = _form.HomeMenuButton;
            activeButton.BackColor = Color.FromArgb(231, 127, 103);
            MakeFormActive(new HomeForm());
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
                    formToMakeActive = new LibraryFormController(new LibraryForm(),
                        (x) => MakeFormActive(x), // pass the method responsible for opening a child form inside the contentPanel
                        _authorService,
                        _genreService,
                        _themeService,
                        _characterService,
                        _oppositionService,
                        _publishedWorkService,
                        _publishedWorkGenreService,
                        _publishedWorkThemeService,
                        _publishedWorkCharacterService,
                        _publishedWorkOppositionService).Form;
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
    }
}
