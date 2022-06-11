using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditWritingRuleFormController : EditEntityController
    {
        private WritingRuleService _writingRuleService;
        private AddNewRuleForm _innerForm;
        public EditWritingRuleFormController(EditForm form, AddNewRuleForm innerForm, WritingRuleService writingRuleService) : base(form, innerForm)
        {
            _writingRuleService = writingRuleService;
            _innerForm = innerForm;
        }

        protected override async Task<bool> EditEntityData()
        {
            var writingRuleName = _entityListBox.SelectedItem.ToString();
            var writingRule = _writingRuleService.GetWritingRule(writingRuleName);

            // Check if the selected writingRule name is not the new writingRule name
            // in other words -> check if the user is trying to edit the writingRule name of the current writingRule
            // if he is trying to edit it to another name,
            // make sure that the new writingRule name doesn't already exist
            var newWritingRuleName = _innerForm.RuleNameTextBox.Text;
            if (writingRuleName != newWritingRuleName && _writingRuleService.Exists(newWritingRuleName))
            {
                MessageBox.Show("Вече съществува правописно правило с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new WritingRule()
            {
                Name = _innerForm.RuleNameTextBox.Text,
                Description = _innerForm.RuleDescriptionTextBox.Text
            };

            await _writingRuleService.EditWritingRule(writingRule, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var writingRuleName = _entityListBox.SelectedItem.ToString();
            var writingRule = _writingRuleService.GetWritingRule(writingRuleName);

            _innerForm.RuleNameTextBox.Text = writingRule.Name;
            _innerForm.RuleDescriptionTextBox.Text = writingRule.Description;
        }

        protected override void LoadEntityListBox(int selectedIndex = -1)
        {
            _entityListBox.Items.Clear();
            var allWritingRuleNames = _writingRuleService.GetAllWritingRulesNames();
            Helper.LoadListBoxData(_entityListBox, allWritingRuleNames, selectedIndex);
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }

            return Helper.CheckIfTextBoxesFilled(
                _innerForm.RuleNameTextBox,
                _innerForm.RuleDescriptionTextBox
                );
        }
    }
}
