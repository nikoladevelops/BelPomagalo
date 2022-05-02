using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditAuthorFormController : EditEntityController
    {
        public EditAuthorFormController(EditForm form, AddNewAuthorForm innerForm) : base(form, innerForm)
        {
            entityLabel.Text += "автор";
        }
        protected override void HandleEditButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
