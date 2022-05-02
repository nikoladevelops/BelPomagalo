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
