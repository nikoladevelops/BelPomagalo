using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewCharacterFormController : AddEntityController<AddNewCharacterForm>
    {
        private readonly FormDataController _controller;
        public AddNewCharacterFormController(AddNewCharacterForm form):base(form)
        {
            _controller = new FormDataController();
            LoadFormData();
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
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
        private void LoadFormData()
        {
            Helper.LoadListBoxData(_form.AuthorListBox, _controller.GetAllAuthorsNames(), true);
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
    }
}
