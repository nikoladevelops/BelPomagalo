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
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var author = new Author()
            {
                Name = _form.AuthorNameTextBox.Text,
                Description = _form.AuthorDescriptionTextBox.Text,
                BornLocation=_form.AuthorBornLocationTextBox.Text,
                BornDate=_form.AuthorBornDateTextBox.Text,
                DiedDate=_form.AuthorDiedDateTextBox.Text
            };
            await _authorService.AddAuthor(author);
        }
    }
}
