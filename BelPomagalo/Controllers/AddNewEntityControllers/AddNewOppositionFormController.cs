using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewOppositionFormController:AddEntityController<AddNewOppositionForm>
    {
        private readonly OppositionService _oppositionService;
        public AddNewOppositionFormController(AddNewOppositionForm form, OppositionService oppositionService) :base(form)
        {
            _oppositionService = oppositionService;
        }

        protected override async Task<bool> AddNewEntity()
        {
            var opposition = new Opposition()
            {
                Name = _form.OppositionNameTextBox.Text,
                Description = _form.OppositionDescriptionTextBox.Text
            };
            await _oppositionService.AddOpposition(opposition);
            return true;
        }

        protected override bool ValidateEntityData()
        {
            return Helper.CheckIfTextBoxesFilled(_form.OppositionNameTextBox, _form.OppositionDescriptionTextBox);
        }
    }
}
