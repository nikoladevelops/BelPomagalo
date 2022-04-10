using BelPomagalo.Models;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal class AddNewOppositionFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewOppositionForm _form;
        public AddNewOppositionFormController(AddNewOppositionForm form)
        {
            _controller = new FormDataController();
            _form = form;

            _form.AddNewOppositionButton.Click += HandleAddNewOppositionButtonClick;
        }
        public AddNewOppositionForm Form { get => _form; }
        private async void HandleAddNewOppositionButtonClick(object? sender, EventArgs e)
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
