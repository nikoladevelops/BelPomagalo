using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditPublishedWorkFormController : EditEntityController
    {
        public EditPublishedWorkFormController(EditForm form, AddNewPublishedWorkForm innerForm) : base(form, innerForm)
        {
            entityLabel.Text += "произведение";
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
