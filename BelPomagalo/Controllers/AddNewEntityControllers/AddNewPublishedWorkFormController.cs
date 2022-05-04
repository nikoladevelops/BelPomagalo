using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewPublishedWorkFormController:AddEntityController<AddNewPublishedWorkForm>
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
        public AddNewPublishedWorkFormController(AddNewPublishedWorkForm form, AuthorService authorService,
            GenreService genreService, ThemeService themeService,CharacterService characterService, OppositionService oppositionService,
            PublishedWorkService publishedWorkService, PublishedWorkGenreService publishedWorkGenreService, PublishedWorkThemeService publishedWorkThemeService,
            PublishedWorkCharacterService publishedWorkCharacterService, PublishedWorkOppositionService publishedWorkOppositionService)
            :base(form)
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

            LoadFormData();
        }
        private void LoadFormData()
        {
            Helper.LoadListBoxData(_form.AuthorListBox, _authorService.GetAllAuthorsNames());
            Helper.LoadListBoxData(_form.GenreListBox, _genreService.GetAllGenresNames(), false);
            Helper.LoadListBoxData(_form.ThemeListBox, _themeService.GetAllThemesNames(), false);

            var currentSelectedAuthor = _authorService.GetAuthor(_form.AuthorListBox.SelectedItem.ToString());
            Helper.LoadListBoxData(_form.CharacterListBox, _characterService.GetAllCharactersNamesOfAuthor(currentSelectedAuthor.Id), false);

            Helper.LoadListBoxData(_form.OppositionListBox, _oppositionService.GetAllOppositionsNames(), false);

            _form.AuthorListBox.SelectedIndexChanged += HandleAuthorListBoxSelectedIndexChanged;
        }
        public void HandleAuthorListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            var authorName = _form.AuthorListBox.SelectedItem.ToString();

            var author = _authorService.GetAuthor(authorName);
            Helper.LoadListBoxData(_form.CharacterListBox, _characterService.GetAllCharactersNamesOfAuthor(author.Id), false);
        }

        protected override bool ValidateEntityData()
        {
            var result = Helper.CheckIfListBoxesHaveSelectedIndex(
                _form.GenreListBox,
                _form.ThemeListBox,
                _form.CharacterListBox,
                _form.OppositionListBox
                );
            return result && Helper.CheckIfTextBoxesFilled(
                _form.NameTextBox,
                _form.PublishedDateTextBox,
                _form.CompositionTextBox,
                _form.MotivesAndFiguresTextBox,
                _form.IdeologicalSuggestionsTextBox,
                _form.RemarksTextBox
                );
        }

        protected override async Task<bool> AddNewEntity()
        {
            var name = _form.NameTextBox.Text;
            var author = _authorService.GetAuthor(_form.AuthorListBox.SelectedItem.ToString());
            
            // Check if a published work with this name already belongs to this author
            // if it is, show an error message
            if (_publishedWorkService.IsOwnedByAuthor(name, author))
            {
                MessageBox.Show("Този автор има произведение с такова име.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var genres = new List<Genre>();
            foreach (var selectedItem in _form.GenreListBox.SelectedItems)
            {
                var selectedGenre = _genreService.GetGenre(selectedItem.ToString());
                genres.Add(selectedGenre);
            }

            var themes = new List<Theme>();
            foreach (var selectedItem in _form.ThemeListBox.SelectedItems)
            {
                var selectedTheme = _themeService.GetTheme(selectedItem.ToString());
                themes.Add(selectedTheme);
            }

            var characters = new List<Character>();
            foreach (var selectedItem in _form.CharacterListBox.SelectedItems)
            {
                var selectedCharacter = _characterService.GetCharacter(selectedItem.ToString(), author);
                characters.Add(selectedCharacter);
            }

            var oppositions = new List<Opposition>();
            foreach (var selectedItem in _form.OppositionListBox.SelectedItems)
            {
                var selectedOpposition = _oppositionService.GetOpposition(selectedItem.ToString());
                oppositions.Add(selectedOpposition);
            }

            var publishedWork = new PublishedWork()
            {
                Name = name,
                AuthorId = author.Id,
                PublishedDate = _form.PublishedDateTextBox.Text,
                CompositionDetails = _form.CompositionTextBox.Text,
                MotivesAndFigures = _form.MotivesAndFiguresTextBox.Text,
                IdeologicalSuggestions = _form.IdeologicalSuggestionsTextBox.Text,
                Remarks = _form.RemarksTextBox.Text
            };

            publishedWork = await _publishedWorkService.AddPublishedWork(publishedWork);

            foreach (var genre in genres)
            {
                await _publishedWorkGenreService.AddPublishedWorkGenre(new PublishedWorkGenre() { PublishedWorkId = publishedWork.Id, GenreId = genre.Id });
            }

            foreach (var theme in themes)
            {
                await _publishedWorkThemeService.AddPublishedWorkTheme(new PublishedWorkTheme() { PublishedWorkId = publishedWork.Id, ThemeId = theme.Id });
            }

            foreach (var character in characters)
            {
                await _publishedWorkCharacterService.AddPublishedWorkCharacter(new PublishedWorkCharacter() { PublishedWorkId = publishedWork.Id, CharacterId = character.Id });
            }

            foreach (var opposition in oppositions)
            {
                await _publishedWorkOppositionService.AddPublishedWorkOpposition(new PublishedWorkOpposition() { PublishedWorkId = publishedWork.Id, OppositionId = opposition.Id });
            }
            return true;
        }
    }
}
