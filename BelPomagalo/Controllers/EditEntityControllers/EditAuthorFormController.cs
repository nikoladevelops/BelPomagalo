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

        protected override void EditEntityData()
        {
            throw new NotImplementedException();
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            throw new NotImplementedException();
        }

        protected override void LoadEntityListbox()
        {
            throw new NotImplementedException();
        }

        protected override bool ValidateEntityData()
        {
            throw new NotImplementedException();
        }
    }
}
