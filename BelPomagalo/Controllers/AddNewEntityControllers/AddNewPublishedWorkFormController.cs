using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewPublishedWorkFormController:AddEntityController<AddNewPublishedWorkForm>
    {
        private readonly FormDataController _controller;
        public AddNewPublishedWorkFormController(AddNewPublishedWorkForm form):base(form)
        {
            _controller = new FormDataController();
            LoadFormData();
        }
        private void LoadFormData()
        {
            Helper.LoadListBoxData(_form.AuthorListBox, _controller.GetAllAuthorsNames());
            Helper.LoadListBoxData(_form.GenreListBox, _controller.GetAllGenresNames(), false);
            Helper.LoadListBoxData(_form.ThemeListBox, _controller.GetAllThemesNames(), false);

            var currentSelectedAuthor = _controller.GetAuthor(_form.AuthorListBox.SelectedItem.ToString());
            Helper.LoadListBoxData(_form.CharacterListBox, _controller.GetCharactersNamesOfAuthor(currentSelectedAuthor.Id), false);

            Helper.LoadListBoxData(_form.OppositionListBox, _controller.GetAllOppositionsNames(), false);

            _form.AuthorListBox.SelectedIndexChanged += HandleAuthorListBoxSelectedIndexChanged;
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var name = _form.NameTextBox.Text;
            var author = _controller.GetAuthor(_form.AuthorListBox.SelectedItem.ToString());

            var genres = new List<Genre>();
            foreach (var selectedItem in _form.GenreListBox.SelectedItems)
            {
                var selectedGenre = _controller.GetGenre(selectedItem.ToString());
                genres.Add(selectedGenre);
            }

            var themes = new List<Theme>();
            foreach (var selectedItem in _form.ThemeListBox.SelectedItems)
            {
                var selectedTheme = _controller.GetTheme(selectedItem.ToString());
                themes.Add(selectedTheme);
            }

            var characters = new List<Character>();
            foreach (var selectedItem in _form.CharacterListBox.SelectedItems)
            {
                var selectedCharacter = _controller.GetCharacter(selectedItem.ToString());
                characters.Add(selectedCharacter);
            }

            var oppositions = new List<Opposition>();
            foreach (var selectedItem in oppositions)
            {
                var selectedOpposition = _controller.GetOpposition(selectedItem.ToString());
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

            publishedWork = await _controller.AddPublishedWork(publishedWork);

            foreach (var genre in genres)
            {
                await _controller.AddPublishedWorkGenre(new PublishedWorkGenre() { PublishedWorkId = publishedWork.Id, GenreId = genre.Id });
            }

            foreach (var theme in themes)
            {
                await _controller.AddPublishedWorkTheme(new PublishedWorkTheme() { PublishedWorkId = publishedWork.Id, ThemeId = theme.Id });
            }

            foreach (var character in characters)
            {
                await _controller.AddPublishedWorkCharacter(new PublishedWorkCharacter() { PublishedWorkId = publishedWork.Id, CharacterId = character.Id });
            }

            foreach (var opposition in oppositions)
            {
                await _controller.AddPublishedWorkOpposition(new PublishedWorkOpposition() { PublishedWorkId = publishedWork.Id, OppositionId = opposition.Id });
            }
        }
        public void HandleAuthorListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            var authorName = _form.AuthorListBox.SelectedItem.ToString();

            var author = _controller.GetAuthor(authorName);
            Helper.LoadListBoxData(_form.CharacterListBox, _controller.GetCharactersNamesOfAuthor(author.Id), false);
        }
    }
}
