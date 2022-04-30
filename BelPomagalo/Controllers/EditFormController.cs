using BelPomagalo.Controllers.AddNewEntityControllers;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Controllers
{
    internal class EditFormController : Controller<EditForm>
    {
        public EditFormController(EditForm form, IAddForm innerForm) : base(form)
        {
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

        private void HandleEditButtonClick(object? sender, EventArgs e)
        {
            MessageBox.Show("test");
        }
    }
}
