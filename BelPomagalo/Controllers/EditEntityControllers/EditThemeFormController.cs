using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditThemeFormController : EditEntityController
    {
        public EditThemeFormController(EditForm form, AddNewThemeForm innerForm) : base(form, innerForm)
        {
        }

        protected override void HandleEditButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
