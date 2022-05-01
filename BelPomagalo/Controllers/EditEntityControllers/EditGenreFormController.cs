using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditGenreFormController : EditEntityController
    {
        public EditGenreFormController(EditForm form, AddNewGenreForm innerForm) : base(form, innerForm)
        {
        }

        protected override void HandleEditButtonClick(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
