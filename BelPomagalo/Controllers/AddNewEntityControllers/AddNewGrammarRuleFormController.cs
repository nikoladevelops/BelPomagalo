using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewGrammarRuleFormController : AddEntityController<AddNewRuleForm>
    {
        private GrammarRuleService _grammarRuleService;
        public AddNewGrammarRuleFormController(AddNewRuleForm form, GrammarRuleService grammarRuleService) : base(form)
        {
            _grammarRuleService = grammarRuleService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            // Check if a gramamrRule with this name already exists
            // if it does, show an error message
            if (_grammarRuleService.Exists(_form.RuleNameTextBox.Text))
            {
                MessageBox.Show("Вече съществува граматично правило с такова име.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var grammarRule = new GrammarRule()
            {
                Name = _form.RuleNameTextBox.Text,
                Description = _form.RuleDescriptionTextBox.Text
            };

            await _grammarRuleService.AddGrammarRule(grammarRule);
            return true;
        }

        protected override bool ValidateEntityData()
        {
            return Helper.CheckIfTextBoxesFilled(
                _form.RuleNameTextBox,
                _form.RuleDescriptionTextBox);
        }
    }
}
