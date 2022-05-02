using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.AddNewEntityControllers
{
    internal abstract class AddEntityController<T> : Controller<T> where T : Form, IAddForm
    {
        public AddEntityController(T form) : base(form)
        {
            _form.AddButton.Click += HandleAddNewEntityButtonClick;
        }
        private void HandleAddNewEntityButtonClick(object? sender, EventArgs e) 
        {
            if (!ValidateEntityData())
            {
                MessageBox.Show("Не сте попълнили всички полета!", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = MessageBox.Show("Сигурни ли сте че искате да направите нов запис?", "Сигурни ли сте?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                AddNewEntity();
                MessageBox.Show("Новият запис беше добавен успешно!", "Успешно запаметен запис.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Validates if everything is filled correctly and displays an erorr message if not.
        /// </summary>
        protected abstract bool ValidateEntityData();

        /// <summary>
        /// This method is called automatically when the add button is clicked and only if ValidateEntityData() returns true.
        /// </summary>
        protected abstract void AddNewEntity();
        
    }
}
