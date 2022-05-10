using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditPublishedWorkFormController : EditEntityController
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
        private readonly AddNewPublishedWorkForm _innerForm;
        public EditPublishedWorkFormController(EditForm form, AddNewPublishedWorkForm innerForm, AuthorService authorService,
            GenreService genreService, ThemeService themeService, CharacterService characterService, OppositionService oppositionService,
            PublishedWorkService publishedWorkService, PublishedWorkGenreService publishedWorkGenreService, PublishedWorkThemeService publishedWorkThemeService,
            PublishedWorkCharacterService publishedWorkCharacterService, PublishedWorkOppositionService publishedWorkOppositionService) : base(form, innerForm)
        {
            _entityLabel.Text += "произведение";

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

            _innerForm = innerForm;
            LoadAdditionalListBox(0);
            _additionalLabel.Text += "автор";
            _additionalLabel.Visible = true;
            _additionalListBox.Visible = true;

            _innerForm.CompositionTextBox.Location = _innerForm.GenreListBox.Location;
            _innerForm.CompositionLabel.Location = _innerForm.GenreLabel.Location;

            _innerForm.GenreListBox.Location = _innerForm.AuthorListBox.Location;
            _innerForm.GenreLabel.Location = _innerForm.AuthorLabel.Location;


            _innerForm.AuthorListBox.Visible = false;
            _innerForm.AuthorLabel.Visible = false;
        }
        protected override async Task<bool> EditEntityData()
        {
            var authorName = _additionalListBox.SelectedItem.ToString();
            var currentAuthor = _authorService.GetAuthor(authorName);

            var publishedWorkName = _entityListBox.SelectedItem.ToString();
            var publishedWorkToEdit = _publishedWorkService.GetPublishedWork(publishedWorkName, currentAuthor);

            var newPublishedWorkName = _innerForm.NameTextBox.Text;

            // make sure to display an error if the current author already owns a published work with this name
            if (publishedWorkName != newPublishedWorkName && _publishedWorkService.IsOwnedByAuthor(newPublishedWorkName, currentAuthor))
            {
                MessageBox.Show("Вече съществува произведение с такова име, направен от този автор.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var genres = new List<Genre>();
            foreach (var selectedItem in _innerForm.GenreListBox.SelectedItems)
            {
                var selectedGenre = _genreService.GetGenre(selectedItem.ToString());
                genres.Add(selectedGenre);
            }

            var themes = new List<Theme>();
            foreach (var selectedItem in _innerForm.ThemeListBox.SelectedItems)
            {
                var selectedTheme = _themeService.GetTheme(selectedItem.ToString());
                themes.Add(selectedTheme);
            }

            var characters = new List<Character>();
            foreach (var selectedItem in _innerForm.CharacterListBox.SelectedItems)
            {
                var selectedCharacter = _characterService.GetCharacter(selectedItem.ToString(), currentAuthor);
                characters.Add(selectedCharacter);
            }

            var oppositions = new List<Opposition>();
            foreach (var selectedItem in _innerForm.OppositionListBox.SelectedItems)
            {
                var selectedOpposition = _oppositionService.GetOpposition(selectedItem.ToString());
                oppositions.Add(selectedOpposition);
            }

            var changesToApply = new PublishedWork()
            {
                Name = _innerForm.NameTextBox.Text,
                PublishedDate = _innerForm.PublishedDateTextBox.Text,
                CompositionDetails = _innerForm.CompositionTextBox.Text,
                MotivesAndFigures = _innerForm.MotivesAndFiguresTextBox.Text,
                IdeologicalSuggestions = _innerForm.IdeologicalSuggestionsTextBox.Text,
                Remarks = _innerForm.RemarksTextBox.Text,
                AuthorId = currentAuthor.Id
            };

            await _publishedWorkService.EditPublishedWork(publishedWorkToEdit, changesToApply);
            await _publishedWorkCharacterService.ChangeCharacters(publishedWorkToEdit, characters);
            await _publishedWorkGenreService.ChangeGenres(publishedWorkToEdit, genres);
            await _publishedWorkOppositionService.ChangeOppositions(publishedWorkToEdit, oppositions);
            await _publishedWorkThemeService.ChangeThemes(publishedWorkToEdit, themes);

            LoadAdditionalListBox(_additionalListBox.SelectedIndex);

            _entityListBox.SelectedIndex = _entityListBox.Items.IndexOf(changesToApply.Name);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_additionalListBox.SelectedIndex == -1)
            {
                return;
            }

            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var authorName = _additionalListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            var publishedWorkName = _entityListBox.SelectedItem.ToString();
            var publishedWork = _publishedWorkService.GetPublishedWork(publishedWorkName, author);

            _innerForm.NameTextBox.Text = publishedWork.Name;
            _innerForm.PublishedDateTextBox.Text = publishedWork.PublishedDate;
            _innerForm.CompositionTextBox.Text = publishedWork.CompositionDetails;
            _innerForm.MotivesAndFiguresTextBox.Text = publishedWork.MotivesAndFigures;
            _innerForm.IdeologicalSuggestionsTextBox.Text = publishedWork.IdeologicalSuggestions;
            _innerForm.RemarksTextBox.Text = publishedWork.Remarks;

            Helper.LoadListBoxData(_innerForm.GenreListBox, _genreService.GetAllGenresNames(), _publishedWorkGenreService.GetPublishedWorkGenresNames(publishedWork));
            Helper.LoadListBoxData(_innerForm.CharacterListBox, _characterService.GetAllCharactersNamesOfAuthor(author.Id), _publishedWorkCharacterService.GetPublishedWorkCharactersNames(publishedWork));
            Helper.LoadListBoxData(_innerForm.ThemeListBox, _themeService.GetAllThemesNames(), _publishedWorkThemeService.GetPublishedWorkThemesNames(publishedWork));
            Helper.LoadListBoxData(_innerForm.OppositionListBox, _oppositionService.GetAllOppositionsNames(), _publishedWorkOppositionService.GetPublishedWorkOppositionsNames(publishedWork));
        }

        protected override void LoadEntityListBox(int selectedIndex)
        {
        }

        protected override bool ValidateEntityData()
        {
            var result = Helper.CheckIfListBoxesHaveSelectedIndex(
                _innerForm.GenreListBox,
                _innerForm.ThemeListBox,
                _innerForm.CharacterListBox,
                _innerForm.OppositionListBox,
                _entityListBox,
                _additionalListBox
                );
            return result && Helper.CheckIfTextBoxesFilled(
                _innerForm.NameTextBox,
                _innerForm.PublishedDateTextBox,
                _innerForm.CompositionTextBox,
                _innerForm.MotivesAndFiguresTextBox,
                _innerForm.IdeologicalSuggestionsTextBox,
                _innerForm.RemarksTextBox
                );
        }
        protected override void LoadAdditionalListBox(int selectedIndex)
        {
            _additionalListBox.Items.Clear();
            var allAuthorsNames = _authorService.GetAllAuthorsNames();
            Helper.LoadListBoxData(_additionalListBox, allAuthorsNames, selectedIndex);
        }
        protected override void LoadAdditionalDataInAppropriateControls()
        {
            if (_additionalListBox.SelectedIndex == -1)
            {
                return;
            }

            var authorName = _additionalListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            Helper.LoadListBoxData(_entityListBox, _publishedWorkService.GetPublishedWorksNames(author.Id));
        }
    }
}
