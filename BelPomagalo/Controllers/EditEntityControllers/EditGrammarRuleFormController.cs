using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditGrammarRuleFormController : EditEntityController
    {
        private GrammarRuleService _grammarRuleService;
        private AddNewRuleForm _innerForm;
        public EditGrammarRuleFormController(EditForm form, AddNewRuleForm innerForm, GrammarRuleService grammarRuleService) : base(form, innerForm)
        {
            _grammarRuleService = grammarRuleService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }

        protected override async Task<bool> EditEntityData()
        {
            var grammarRuleName = _entityListBox.SelectedItem.ToString();
            var grammarRule = _grammarRuleService.GetGrammarRule(grammarRuleName);

            // Check if the selected grammarRule name is not the new grammarRule name
            // in other words -> check if the user is trying to edit the grammarRule name of the current grammarRule
            // if he is trying to edit it to another name,
            // make sure that the new grammarRule name doesn't already exist
            var newGrammarRuleName = _innerForm.RuleNameTextBox.Text;
            if (grammarRuleName != newGrammarRuleName && _grammarRuleService.Exists(newGrammarRuleName))
            {
                MessageBox.Show("Вече съществува граматично правило с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new GrammarRule()
            {
                Name = _innerForm.RuleNameTextBox.Text,
                Description = _innerForm.RuleDescriptionTextBox.Text
            };

            await _grammarRuleService.EditGrammarRule(grammarRule, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var grammarRuleName = _entityListBox.SelectedItem.ToString();
            var grammarRule = _grammarRuleService.GetGrammarRule(grammarRuleName);

            _innerForm.RuleNameTextBox.Text = grammarRule.Name;
            _innerForm.RuleDescriptionTextBox.Text = grammarRule.Description;
        }

        protected override void LoadEntityListBox(int selectedIndex = -1)
        {
            _entityListBox.Items.Clear();
            var allGrammarRulesNames = _grammarRuleService.GetAllGrammarRulesNames();
            Helper.LoadListBoxData(_entityListBox, allGrammarRulesNames, selectedIndex);
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

        protected override void DeleteEntityData()
        {
            var grammarRuleName = _entityListBox.SelectedItem.ToString();
            var grammarRule = _grammarRuleService.GetGrammarRule(grammarRuleName);

            _grammarRuleService.Delete(grammarRule);
            LoadEntityListBox(0);
        }
    }
}
