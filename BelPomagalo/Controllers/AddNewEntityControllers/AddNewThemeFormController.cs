using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewThemeFormController:AddEntityController<AddNewThemeForm>
    {
        private readonly ThemeService _themeService;
        public AddNewThemeFormController(AddNewThemeForm form, ThemeService themeService):base(form)
        {
            _themeService = themeService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            // Check if a theme with this name already exists
            // if it does, show an error message
            if (_themeService.Exists(_form.ThemeNameTextBox.Text))
            {
                MessageBox.Show("Вече съществува такава тема.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var theme = new Theme()
            {
                Name = _form.ThemeNameTextBox.Text,
                Description = _form.ThemeDescriptionTextBox.Text
            };
            await _themeService.AddTheme(theme);
            return true;
        }

        protected override bool ValidateEntityData()
        {
            return Helper.CheckIfTextBoxesFilled(_form.ThemeNameTextBox, _form.ThemeDescriptionTextBox);
        }
    }
}
