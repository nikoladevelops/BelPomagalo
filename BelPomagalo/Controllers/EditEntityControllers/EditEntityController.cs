using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal abstract class EditEntityController : Controller<EditForm>
    {
        protected Label _entityLabel;
        protected Label _additionalLabel;
        protected ListBox _entityListBox;
        protected ListBox _additionalListBox;
        public EditEntityController(EditForm form, IAddForm innerForm) : base(form)
        {
            _entityLabel = _form.EntityLabel;
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
            _form.EntityListBox.SelectedIndexChanged += HandleEntityListBoxSelectedIndexChanged;
            _entityListBox = _form.EntityListBox;
            _additionalLabel = _form.AdditionalLabel;
            _additionalListBox = _form.AdditionalListBox;
            _additionalListBox.SelectedIndexChanged += HandleAdditionalListBoxSelectedIndexChanged;
        }

        private void HandleEntityListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadEntityDataInAppropriateControls();
        }
        private void HandleAdditionalListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadAdditionalDataInAppropriateControls();
        }

        private async void HandleEditButtonClick(object? sender, EventArgs e) 
        {
            if (!ValidateEntityData())
            {
                MessageBox.Show("Не сте попълнили всички полета!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Сигурни ли сте че искате да приложите промените?", "Сигурни ли сте?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var isSuccessful = await EditEntityData();
                if (isSuccessful)
                {
                    MessageBox.Show("Редакцията беше успешна!", "Успешна редакция.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        /// <summary>
        /// Loads all entities in the entityListBox.
        /// </summary>
        /// <param name="selectedIndex">The index to be selected in the entityListBox.</param>
        protected abstract void LoadEntityListBox(int selectedIndex = -1);
        /// <summary>
        /// Loads a selected entity's data in the appropriate controls.
        /// This method is automatically called when the selected index event of
        /// entityListBox is raised.
        /// </summary>
        protected abstract void LoadEntityDataInAppropriateControls();
        /// <summary>
        /// Returns true if every required data control is filled.
        /// This method is automatically called when the edit button is clicked and depending
        /// on the value it returns, it may show an error message.
        /// </summary>
        /// <returns></returns>
        protected abstract bool ValidateEntityData();
        /// <summary>
        /// This method is automatically called when the edit button is clicked and only if
        /// ValidateEntityData() returns true.
        /// </summary>
        protected abstract Task<bool> EditEntityData();

        /// <summary>
        /// Loads all entities in the additionalLisBox.
        /// </summary>
        /// <param name="selectedIndex">The index to be selected in the additionalListBox.</param>
        protected virtual void LoadAdditionalListBox(int selectedIndex = -1) 
        {
        }
        /// <summary>
        /// Loads a selected entity's data in the appropriate controls.
        /// This method is automatically called when the selected index event of
        /// additionalListBox is raised.
        /// </summary>
        protected virtual void LoadAdditionalDataInAppropriateControls() 
        {
        }
    }
}
