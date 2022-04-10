using BelPomagalo.Models;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewOppositionFormController:AddEntityController<AddNewOppositionForm>
    {
        private readonly FormDataController _controller;
        public AddNewOppositionFormController(AddNewOppositionForm form):base(form)
        {
            _controller = new FormDataController();
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        protected override async void HandleAddNewEntityButtonClick(object? sender, EventArgs e)
        {
            var opposition = new Opposition()
            {
                Name = _form.OppositionNameTextBox.Text,
                Description = _form.OppositionDescriptionTextBox.Text
            };
            await _controller.AddOpposition(opposition);
        }
    }
}
