using BelPomagalo.Models;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewThemeFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewThemeForm _form;
        public AddNewThemeFormController(AddNewThemeForm form)
        {
            _controller = new FormDataController();
            _form = form;

            _form.AddNewThemeButton.Click += HandleAddNewThemeButtonClick;
        }
        public AddNewThemeForm Form { get => _form; }
        private async void HandleAddNewThemeButtonClick(object? sender, EventArgs e)
        {
            var theme = new Theme()
            {
                Name = _form.ThemeNameTextBox.Text,
                Description = _form.ThemeDescriptionTextBox.Text
            };
            await _controller.AddTheme(theme);
        }
    }
}
