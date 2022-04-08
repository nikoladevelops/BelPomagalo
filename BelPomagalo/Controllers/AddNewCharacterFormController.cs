using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views;

namespace BelPomagalo.Controllers
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

        private void HandleAddNeCharacterButtonClick(object? sender, EventArgs e)
        {
            var character = new Character()
            {
                Name = _form.CharacterNameTextBox.Text,
                Description = _form.CharacterDescriptionTextBox.Text
            };

            // await add character
        }

    }
}
