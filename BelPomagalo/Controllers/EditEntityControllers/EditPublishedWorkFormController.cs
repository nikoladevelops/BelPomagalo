using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditPublishedWorkFormController : EditEntityController
    {
        public EditPublishedWorkFormController(EditForm form, AddNewPublishedWorkForm innerForm) : base(form, innerForm)
        {
        }

        protected override void HandleEditButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
