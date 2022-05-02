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
