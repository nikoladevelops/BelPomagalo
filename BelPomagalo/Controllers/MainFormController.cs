using BelPomagalo.Controllers.AddNewEntityControllers;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers
{
    internal class MainFormController:Controller<MainForm>
    {
        private Button activeButton;
        private Form activeForm;

        public MainFormController(MainForm mainForm):base(mainForm)
        {
            _form.HomeMenuButton.Click += MakeMenuButtonActiveOnClick;
            _form.GamesMenuButton.Click += MakeMenuButtonActiveOnClick;
            _form.LibraryMenuButton.Click += MakeMenuButtonActiveOnClick;

            // set the default form that is loaded in the content panel to be HomeForm
            activeButton = _form.HomeMenuButton;
            activeButton.BackColor = Color.FromArgb(231, 127, 103);
            MakeFormActive(new HomeForm());
        }

        private void MakeMenuButtonActiveOnClick(object? sender, EventArgs e)
        {
            if (activeButton != null) 
            {
                activeButton.BackColor = Color.FromArgb(241, 144, 102);
            }
            activeButton = sender as Button;
            activeButton.BackColor= Color.FromArgb(231, 127, 103);

            Form formToMakeActive = null;
            switch (activeButton.Name)
            {
                case "homeMenuButton":
                    formToMakeActive = new HomeForm();
                    break;
                case "gamesMenuButton":
                    formToMakeActive = new GamesForm();
                    break;
                case "libraryMenuButton":
                    formToMakeActive = new LibraryFormController(new LibraryForm(),
                        (x) => MakeFormActive(x), // pass the method responsible for opening a child form inside the contentPanel
                        new ApplicationDbContext()).Form;
                    break;
                default:
                    break;
            }
            MakeFormActive(formToMakeActive);
        }
        private void MakeFormActive(Form childForm)
        {
            if (activeForm != null) 
            {
                // no need to load the form again, if we are trying to load the same form
                if (childForm.Name == activeForm.Name)
                {
                    return;
                }
                // make sure the old form is closed and doesn't use any resources
                activeForm.Close();
                activeForm.Dispose();
            }
            activeForm = childForm;
            _form.ContentPanel.Controls.Clear(); // just in case, remove any elements in the content panel
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.AutoScroll = true;
            _form.ContentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
