using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewOppositionFormController:AddEntityController<AddNewOppositionForm>
    {
        private readonly OppositionService _oppositionService;
        public AddNewOppositionFormController(AddNewOppositionForm form, OppositionService oppositionService) :base(form)
        {
            _oppositionService = oppositionService;
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var opposition = new Opposition()
            {
                Name = _form.OppositionNameTextBox.Text,
                Description = _form.OppositionDescriptionTextBox.Text
            };
            await _oppositionService.AddOpposition(opposition);
        }
    }
}
