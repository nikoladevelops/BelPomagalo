using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewPunctuationRuleFormController : AddEntityController<AddNewRuleForm>
    {
        private PunctuationRuleService _punctuationRuleService;
        public AddNewPunctuationRuleFormController(AddNewRuleForm form, PunctuationRuleService punctuationRuleService) : base(form)
        {
            _punctuationRuleService = punctuationRuleService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            var punctuationRule = new PunctuationRule()
            {
                Name = _form.RuleNameTextBox.Text,
                Description = _form.RuleDescriptionTextBox.Text
            };

            await _punctuationRuleService.AddPunctuationRule(punctuationRule);
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
