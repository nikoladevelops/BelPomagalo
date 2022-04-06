using BelPomagalo.Models;
using BelPomagalo.Views;

namespace BelPomagalo.Controllers
{
    internal class AddNewAuthorFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewAuthorForm _form;
        public AddNewAuthorFormController(AddNewAuthorForm form)
        {
            _controller = new FormDataController();
            _form = form;

            _form.AddNewAuthorButton.Click += HandleAddNewAuthorButtonClick;
        }
        public AddNewAuthorForm Form { get => _form; }
        private async void HandleAddNewAuthorButtonClick(object? sender, EventArgs e)
        {
            var author = new Author()
            {
                Name = _form.AuthorNameTextBox.Text,
                Description = _form.AuthorDescriptionTextBox.Text,
                BornLocation=_form.AuthorBornLocationTextBox.Text,
                BornDate=_form.AuthorBornDateTextBox.Text,
                DiedDate=_form.AuthorDiedDateTextBox.Text
            };
            await _controller.AddAuthor(author);
        }
    }
}
