using BelPomagalo.Models;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewThemeFormController:AddEntityController<AddNewThemeForm>
    {
        private readonly FormDataController _controller;
        public AddNewThemeFormController(AddNewThemeForm form):base(form)
        {
            _controller = new FormDataController();
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
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
