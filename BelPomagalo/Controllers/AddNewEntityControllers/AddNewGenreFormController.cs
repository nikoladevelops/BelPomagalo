using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewGenreFormController : AddEntityController<AddNewGenreForm>
    {
        private readonly GenreService _genreService;
        public AddNewGenreFormController(AddNewGenreForm form, GenreService genreService) :base(form)
        {
            _genreService = genreService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            // Check if a genre with this name already exists
            // if it does, show an error message
            if (_genreService.Exists(_form.GenreNameTextBox.Text))
            {
                MessageBox.Show("Вече съществува такъв жанр.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var genre = new Genre()
            {
                Name = _form.GenreNameTextBox.Text,
                Description = _form.GenreDescriptionTextBox.Text
            };
            await _genreService.AddGenre(genre);
            return true;
        }

        protected override bool ValidateEntityData()
        {
            return Helper.CheckIfTextBoxesFilled(_form.GenreNameTextBox, _form.GenreDescriptionTextBox);
        }
    }
}
