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
