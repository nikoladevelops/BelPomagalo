using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal abstract class EditEntityController : Controller<EditForm>
    {
        public EditEntityController(EditForm form, IAddForm innerForm) : base(form)
        {
            // todo pass all services for each edit entity form
            // todo make a label Edit "Entities"
            // todo assign a value to that label based on the type of form that is passed as parameter innerForm
            // todo load all entities based on that inner form type inside the entityListBox
            // todo when you select a different entity onSelectIndexChanged
            // load the different entity's info in the correct fields / again based on type of the form

            // todo when you click edit button, edit that particular entity's info and save it
            // display a message that it was successful
            innerForm.AddButton.Click += HandleEditButtonClick;
            innerForm.AddButton.Text = "Редактирай";

            var childForm = (Form)innerForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            _form.AutoScroll = true;
            _form.EditPanel.Size = childForm.Size;
            _form.EditPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            _form.Disposed += (x, y) => { childForm.Close(); childForm.Dispose(); };
        }

        protected abstract void HandleEditButtonClick(object? sender, EventArgs e);
    }
}
