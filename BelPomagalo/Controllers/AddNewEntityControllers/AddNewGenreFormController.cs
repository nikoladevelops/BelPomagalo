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
