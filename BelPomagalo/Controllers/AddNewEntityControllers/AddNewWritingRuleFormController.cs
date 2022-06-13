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
            // Check if a writingRule with this name already exists
            // if it does, show an error message
            if (_writingRuleService.Exists(_form.RuleNameTextBox.Text))
            {
                MessageBox.Show("Вече съществува правописно правило с такова име.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

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
