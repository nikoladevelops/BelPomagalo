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

        protected override async void AddNewEntity()
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

        protected override bool ValidateEntityData()
        {
            if (_form.AuthorListBox.SelectedIndex == -1)
            {
                return false;
            }
            return Helper.CheckIfTextBoxesFilled(_form.CharacterNameTextBox, _form.CharacterDescriptionTextBox);
        }

        private void LoadFormData()
        {
            Helper.LoadListBoxData(_form.AuthorListBox, _authorService.GetAllAuthorsNames(), true);
        }
    }
}
