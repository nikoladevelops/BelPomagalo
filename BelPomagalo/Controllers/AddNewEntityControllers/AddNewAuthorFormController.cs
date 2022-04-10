using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewAuthorFormController : AddEntityController<AddNewAuthorForm>
    {
        private readonly FormDataController _controller;
        private readonly ListBox _authorsListBox;
        public AddNewAuthorFormController(AddNewAuthorForm form, ListBox authorsListBox):base(form)
        {
            _controller = new FormDataController();
            _authorsListBox = authorsListBox;
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
            await _controller.AddAuthor(author);
            Helper.LoadListBoxData(_authorsListBox, _controller.GetAllAuthorsNames());
        }
    }
}
