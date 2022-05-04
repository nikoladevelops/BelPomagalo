using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewAuthorFormController : AddEntityController<AddNewAuthorForm>
    {
        private readonly AuthorService _authorService;
        public AddNewAuthorFormController(AddNewAuthorForm form, AuthorService authorService):base(form)
        {
            _authorService = authorService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            // Check if an author with this name already exists
            // if it does, show an error message
            if (_authorService.Exists(_form.AuthorNameTextBox.Text))
            {
                MessageBox.Show("Вече съществува автор с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var author = new Author()
            {
                Name = _form.AuthorNameTextBox.Text,
                Description = _form.AuthorDescriptionTextBox.Text,
                BornLocation = _form.AuthorBornLocationTextBox.Text,
                BornDate = _form.AuthorBornDateTextBox.Text,
                DiedDate = _form.AuthorDiedDateTextBox.Text
            };
            await _authorService.AddAuthor(author);
            return true;
        }

        protected override bool ValidateEntityData()
        {
            return Helper.CheckIfTextBoxesFilled(
                _form.AuthorNameTextBox,
                _form.AuthorDescriptionTextBox,
                _form.AuthorBornLocationTextBox,
                _form.AuthorBornDateTextBox,
                _form.AuthorDiedDateTextBox);
        }
    }
}
