using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewAuthorFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewAuthorForm _form;
        private readonly ListBox _authorsListBox;
        public AddNewAuthorFormController(AddNewAuthorForm form, ListBox authorsListBox)
        {
            _controller = new FormDataController();
            _form = form;
            _authorsListBox= authorsListBox;

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
            Helper.LoadListBoxData(_authorsListBox, _controller.GetAllAuthorsNames());
        }
    }
}
