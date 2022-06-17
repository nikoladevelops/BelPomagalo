using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditThemeFormController : EditEntityController
    {
        private readonly ThemeService _themeService;
        private readonly AddNewThemeForm _innerForm;
        public EditThemeFormController(EditForm form, AddNewThemeForm innerForm, ThemeService themeService) : base(form, innerForm)
        {
            _entityLabel.Text += "тема";
            _themeService = themeService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }

        protected override async Task<bool> EditEntityData()
        {
            var themeName = _entityListBox.SelectedItem.ToString();
            var theme = _themeService.GetTheme(themeName);

            // Check if the selected theme name is not the new theme name
            // in other words -> check if the user is trying to edit the theme name of the current theme
            // if he is trying to edit it to another name,
            // make sure that the new theme name doesn't already exist
            var newThemeName = _innerForm.ThemeNameTextBox.Text;
            if (themeName != newThemeName && _themeService.Exists(newThemeName))
            {
                MessageBox.Show("Вече съществува тема с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new Theme()
            {
                Name = _innerForm.ThemeNameTextBox.Text,
                Description = _innerForm.ThemeDescriptionTextBox.Text
            };

            await _themeService.EditTheme(theme, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var themeName = _entityListBox.SelectedItem.ToString();
            var theme = _themeService.GetTheme(themeName);

            _innerForm.ThemeNameTextBox.Text = theme.Name;
            _innerForm.ThemeDescriptionTextBox.Text = theme.Description;
        }

        protected override void LoadEntityListBox(int selectedIndex)
        {
            _entityListBox.Items.Clear();
            var allThemesNames = _themeService.GetAllThemesNames();
            Helper.LoadListBoxData(_entityListBox, allThemesNames, selectedIndex);
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }

            return Helper.CheckIfTextBoxesFilled(
                _innerForm.ThemeNameTextBox,
                _innerForm.ThemeDescriptionTextBox
                );
        }

        protected override void DeleteEntityData()
        {
            var themeName = _entityListBox.SelectedItem.ToString();
            var theme = _themeService.GetTheme(themeName);

            _themeService.Delete(theme);
            LoadEntityListBox(0);
        }
    }
}
