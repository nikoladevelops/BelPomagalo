using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditCharacterFormController : EditEntityController
    {
        public EditCharacterFormController(EditForm form, AddNewCharacterForm innerForm) : base(form, innerForm)
        {
            entityLabel.Text += "герой";
        }
        protected override void HandleEditButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
