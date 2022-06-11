using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewWritingRuleFormController : AddEntityController<AddNewRuleForm>
    {
        private WritingRuleService _writingRuleService;
        public AddNewWritingRuleFormController(AddNewRuleForm form, WritingRuleService writingRuleService) : base(form)
        {
            _writingRuleService = writingRuleService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            var writingRule = new WritingRule()
            {
                Name = _form.RuleNameTextBox.Text,
                Description = _form.RuleDescriptionTextBox.Text
            };

            await _writingRuleService.AddWritingRule(writingRule);
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
