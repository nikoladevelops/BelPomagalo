using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewGenreFormController : AddEntityController<AddNewGenreForm>
    {
        private readonly GenreService _genreService;
        public AddNewGenreFormController(AddNewGenreForm form, GenreService genreService) :base(form)
        {
            _genreService = genreService;
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var genre = new Genre()
            {
                Name = _form.GenreNameTextBox.Text,
                Description = _form.GenreDescriptionTextBox.Text
            };
            await _genreService.AddGenre(genre);
        }
    }
}
