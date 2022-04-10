using BelPomagalo.Models;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewGenreFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewGenreForm _form;
        public AddNewGenreFormController(AddNewGenreForm form)
        {
            _controller = new FormDataController();
            _form = form;

            _form.AddNewGenreButton.Click += HandleAddNewGenreButtonClick;
        }
        public AddNewGenreForm Form { get => _form; }
        private async void HandleAddNewGenreButtonClick(object? sender, EventArgs e)
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
