using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditOppositionFormController : EditEntityController
    {
        public EditOppositionFormController(EditForm form, AddNewOppositionForm innerForm) : base(form, innerForm)
        {
            entityLabel.Text += "опозиция";
        }
        protected override void HandleEditButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
