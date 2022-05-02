﻿using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal abstract class EditEntityController : Controller<EditForm>
    {
        protected Label entityLabel;
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
            entityLabel = _form.EntityLabel;
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
        }

        private void HandleEntityListBoxSelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadEntityDataInAppropriateControls();
        }

        private void HandleEditButtonClick(object? sender, EventArgs e) 
        {
            if (!ValidateEntityData())
            {
                MessageBox.Show("Не сте попълнили всички полета!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Сигурни ли сте че искате да приложите промените?", "Сигурни ли сте?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                EditEntityData();
                MessageBox.Show("Редакцията беше успешна!", "Успешна редакция.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        /// <summary>
        /// Loads all entities in the entityListBox.
        /// </summary>
        protected abstract void LoadEntityListbox();
        /// <summary>
        /// Loads a selected entity's data in the appropriate controls.
        /// This method is automatically called when the selected index event of
        /// entityListBox is raised.
        /// </summary>
        protected abstract void LoadEntityDataInAppropriateControls();
        /// <summary>
        /// Returns true if every required data control is filled.
        /// This method is automatically called when the edit button is clicked and depending
        /// on the value it returns, it may throw an error message.
        /// </summary>
        /// <returns></returns>
        protected abstract bool ValidateEntityData();
        /// <summary>
        /// This method is automatically called when the edit button is clicked and only if
        /// ValidateEntityData() returns true.
        /// </summary>
        protected abstract void EditEntityData();
    }
}
