using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditGenreFormController : EditEntityController
    {
        public EditGenreFormController(EditForm form, AddNewGenreForm innerForm) : base(form, innerForm)
        {
            entityLabel.Text += "жанр";
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
