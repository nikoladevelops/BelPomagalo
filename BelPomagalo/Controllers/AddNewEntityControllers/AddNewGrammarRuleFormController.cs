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
