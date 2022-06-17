using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditGenreFormController : EditEntityController
    {
        private readonly GenreService _genreService;
        private readonly AddNewGenreForm _innerForm;
        public EditGenreFormController(EditForm form, AddNewGenreForm innerForm, GenreService genreService) : base(form, innerForm)
        {
            _entityLabel.Text += "жанр";
            _genreService = genreService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }

        protected override async Task<bool> EditEntityData()
        {
            var genreName = _entityListBox.SelectedItem.ToString();
            var genre = _genreService.GetGenre(genreName);

            // Check if the selected genre name is not the new genre name
            // in other words -> check if the user is trying to edit the genre name of the current genre
            // if he is trying to edit it to another name,
            // make sure that the new genre name doesn't already exist
            var newGenreName = _innerForm.GenreNameTextBox.Text;
            if (genreName != newGenreName && _genreService.Exists(newGenreName))
            {
                MessageBox.Show("Вече съществува жанр с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new Genre()
            {
                Name = _innerForm.GenreNameTextBox.Text,
                Description = _innerForm.GenreDescriptionTextBox.Text
            };

            await _genreService.EditGenre(genre, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var genreName = _entityListBox.SelectedItem.ToString();
            var genre = _genreService.GetGenre(genreName);

            _innerForm.GenreNameTextBox.Text = genre.Name;
            _innerForm.GenreDescriptionTextBox.Text = genre.Description;
        }

        protected override void LoadEntityListBox(int selectedIndex)
        {
            _entityListBox.Items.Clear();
            var allGenresNames = _genreService.GetAllGenresNames();
            Helper.LoadListBoxData(_entityListBox, allGenresNames, selectedIndex);
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }

            return Helper.CheckIfTextBoxesFilled(
                _innerForm.GenreNameTextBox,
                _innerForm.GenreDescriptionTextBox
                );
        }

        protected override void DeleteEntityData()
        {
            var genreName = _entityListBox.SelectedItem.ToString();
            var genre = _genreService.GetGenre(genreName);

            _genreService.Delete(genre);
            LoadEntityListBox(0);
        }
    }
}
