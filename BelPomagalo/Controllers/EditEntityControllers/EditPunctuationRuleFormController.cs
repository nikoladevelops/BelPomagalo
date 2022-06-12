using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditPunctuationRuleFormController : EditEntityController
    {
        private PunctuationRuleService _punctuationRuleService;
        private AddNewRuleForm _innerForm;
        public EditPunctuationRuleFormController(EditForm form, AddNewRuleForm innerForm, PunctuationRuleService punctuationRuleService) : base(form, innerForm)
        {
            _punctuationRuleService = punctuationRuleService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }

        protected override async Task<bool> EditEntityData()
        {
            var punctuationRuleName = _entityListBox.SelectedItem.ToString();
            var punctuationRule = _punctuationRuleService.GetPunctuationRule(punctuationRuleName);

            // Check if the selected punctuationRule name is not the new punctuationRule name
            // in other words -> check if the user is trying to edit the punctuationRule name of the current punctuationRule
            // if he is trying to edit it to another name,
            // make sure that the new punctuationRule name doesn't already exist
            var newPunctuationRule = _innerForm.RuleNameTextBox.Text;
            if (punctuationRuleName != newPunctuationRule && _punctuationRuleService.Exists(newPunctuationRule))
            {
                MessageBox.Show("Вече съществува пунктуационно правило с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new PunctuationRule()
            {
                Name = _innerForm.RuleNameTextBox.Text,
                Description = _innerForm.RuleDescriptionTextBox.Text
            };

            await _punctuationRuleService.EditPunctuationRule(punctuationRule, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var punctuationRuleName = _entityListBox.SelectedItem.ToString();
            var punctuationRule = _punctuationRuleService.GetPunctuationRule(punctuationRuleName);

            _innerForm.RuleNameTextBox.Text = punctuationRule.Name;
            _innerForm.RuleDescriptionTextBox.Text = punctuationRule.Description;
        }

        protected override void LoadEntityListBox(int selectedIndex = -1)
        {
            _entityListBox.Items.Clear();
            var allPunctuationRulesNames = _punctuationRuleService.GetAllPunctuationRulesNames();
            Helper.LoadListBoxData(_entityListBox, allPunctuationRulesNames, selectedIndex);
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
