using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.DeleteEntityControllers
{
    internal abstract class DeleteEntityController : Controller<DeleteForm>
    {
        protected string warningMessage = "Сигурни ли сте че искате да изтриете този запис?";
        protected Label _entityLabel;
        protected Label _additionalLabel;
        protected ListBox _entityListBox;
        protected ListBox _additionalListBox;

        public DeleteEntityController(DeleteForm form, IAddForm innerForm) : base(form)
        {
            _entityLabel = _form.EntityLabel;
            innerForm.AddButton.Click += HandleDeleteEntity;
            innerForm.AddButton.Text = "Изтрий";

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

        private async void HandleDeleteEntity(object? sender, EventArgs e) 
        {
            var result = MessageBox.Show(warningMessage, "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DeleteEntity();
            }
        }

        /// <summary>
        /// Responsible for the logic of deleting an entity. This method is automatically called
        /// when the Delete button is clicked.
        /// </summary>
        protected virtual void DeleteEntity() 
        {
        }

        private void HandleEntityListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadEntityDataInAppropriateControls();
        }
        private void HandleAdditionalListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadAdditionalDataInAppropriateControls();
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
