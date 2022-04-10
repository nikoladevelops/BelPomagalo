using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewCharacterFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewCharacterForm _form;
        public AddNewCharacterFormController(AddNewCharacterForm form)
        {
            _controller = new FormDataController();
            _form = form;

            Helper.LoadListBoxData(_form.AuthorListBox, _controller.GetAllAuthorsNames(), true);

            _form.AddNewCharacterButton.Click += HandleAddNeCharacterButtonClick;
        }
        public AddNewCharacterForm Form { get => _form; }

        private async void HandleAddNeCharacterButtonClick(object? sender, EventArgs e)
        {
            var author = _controller.GetAuthor(_form.AuthorListBox.SelectedItem.ToString());
            var character = new Character()
            {
                Name = _form.CharacterNameTextBox.Text,
                Description = _form.CharacterDescriptionTextBox.Text,
                AuthorId = author.Id
            };

            await _controller.AddCharacter(character);
        }

    }
}
