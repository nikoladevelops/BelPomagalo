using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditOppositionFormController : EditEntityController
    {
        private readonly OppositionService _oppositionService;
        private readonly AddNewOppositionForm _innerForm;
        public EditOppositionFormController(EditForm form, AddNewOppositionForm innerForm, OppositionService oppositionService) : base(form, innerForm)
        {
            _entityLabel.Text += "опозиция";
            _oppositionService = oppositionService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }


        protected override async Task<bool> EditEntityData()
        {
            var oppositionName = _entityListBox.SelectedItem.ToString();
            var opposition = _oppositionService.GetOpposition(oppositionName);

            // Check if the selected opposition name is not the new opposition name
            // in other words -> check if the user is trying to edit the opposition name of the current opposition
            // if he is trying to edit it to another name,
            // make sure that the new opposition name doesn't already exist
            var newOppositionName = _innerForm.OppositionNameTextBox.Text;
            if (oppositionName != newOppositionName && _oppositionService.Exists(newOppositionName))
            {
                MessageBox.Show("Вече съществува опозиция с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new Opposition()
            {
                Name = _innerForm.OppositionNameTextBox.Text,
                Description = _innerForm.OppositionDescriptionTextBox.Text
            };

            await _oppositionService.EditOpposition(opposition, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var oppositionName = _entityListBox.SelectedItem.ToString();
            var opposition = _oppositionService.GetOpposition(oppositionName);

            _innerForm.OppositionNameTextBox.Text = opposition.Name;
            _innerForm.OppositionDescriptionTextBox.Text = opposition.Description;
        }

        protected override void LoadEntityListBox(int selectedIndex)
        {
            _entityListBox.Items.Clear();
            var allOppositionsNames = _oppositionService.GetAllOppositionsNames();
            Helper.LoadListBoxData(_entityListBox, allOppositionsNames, selectedIndex);
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }

            return Helper.CheckIfTextBoxesFilled(
                _innerForm.OppositionNameTextBox,
                _innerForm.OppositionDescriptionTextBox
                );
        }
    }
}
