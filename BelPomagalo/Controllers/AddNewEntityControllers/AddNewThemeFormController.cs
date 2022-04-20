using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewThemeFormController:AddEntityController<AddNewThemeForm>
    {
        private readonly ThemeService _themeService;
        public AddNewThemeFormController(AddNewThemeForm form, ThemeService themeService):base(form)
        {
            _themeService = themeService;
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var theme = new Theme()
            {
                Name = _form.ThemeNameTextBox.Text,
                Description = _form.ThemeDescriptionTextBox.Text
            };
            await _themeService.AddTheme(theme);
        }
    }
}
