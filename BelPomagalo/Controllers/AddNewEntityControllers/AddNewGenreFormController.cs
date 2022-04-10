using BelPomagalo.Models;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewGenreFormController : AddEntityController<AddNewGenreForm>
    {
        private readonly FormDataController _controller;
        public AddNewGenreFormController(AddNewGenreForm form):base(form)
        {
            _controller = new FormDataController();
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var genre = new Genre()
            {
                Name = _form.GenreNameTextBox.Text,
                Description = _form.GenreDescriptionTextBox.Text
            };
            await _controller.AddGenre(genre);
        }
    }
}
