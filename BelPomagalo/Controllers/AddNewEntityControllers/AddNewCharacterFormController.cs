using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewCharacterFormController : AddEntityController<AddNewCharacterForm>
    {
        private readonly CharacterService _characterService;
        private readonly AuthorService _authorService;
        public AddNewCharacterFormController(AddNewCharacterForm form, CharacterService characterService,
            AuthorService authorService) :base(form)
        {
            _characterService = characterService;
            _authorService = authorService;
            LoadFormData();
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var author = _authorService.GetAuthor(_form.AuthorListBox.SelectedItem.ToString());
            var character = new Character()
            {
                Name = _form.CharacterNameTextBox.Text,
                Description = _form.CharacterDescriptionTextBox.Text,
                AuthorId = author.Id
            };

            await _characterService.AddCharacter(character);
        }
        private void LoadFormData()
        {
            Helper.LoadListBoxData(_form.AuthorListBox, _authorService.GetAllAuthorsNames(), true);
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
    }
}
