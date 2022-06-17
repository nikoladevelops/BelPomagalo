using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditAuthorFormController : EditEntityController
    {
        private readonly AuthorService _authorService;
        private readonly AddNewAuthorForm _innerForm;
        public EditAuthorFormController(EditForm form, AddNewAuthorForm innerForm, AuthorService authorService) : base(form, innerForm)
        {
            _entityLabel.Text += "автор";
            _authorService = authorService;
            _innerForm = innerForm;
            LoadEntityListBox(0);
        }

        protected override async Task<bool> EditEntityData()
        {
            var authorName = _entityListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            // Check if an author with that name already exists
            // If an author with that name exists
            // check if that author is actually the author you are currently trying to edit
            // if its not the author you're currently trying to edit, then you should't save the changes
            // if it is the author you are editing, then continue and save the changes

            if (_authorService.Exists(_innerForm.AuthorNameTextBox.Text) &&
                author.Id != _authorService.GetAuthor(_innerForm.AuthorNameTextBox.Text).Id)
            {
                MessageBox.Show("Вече съществува автор с такова име. Моля пробвайте друго.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            var changesToApply = new Author()
            {
                Name = _innerForm.AuthorNameTextBox.Text,
                Description = _innerForm.AuthorDescriptionTextBox.Text,
                BornDate = _innerForm.AuthorBornDateTextBox.Text,
                DiedDate = _innerForm.AuthorDiedDateTextBox.Text,
                BornLocation = _innerForm.AuthorBornLocationTextBox.Text
            };

            await _authorService.EditAuthor(author, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var authorName = _entityListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            _innerForm.AuthorNameTextBox.Text = author.Name;
            _innerForm.AuthorDescriptionTextBox.Text = author.Description;
            _innerForm.AuthorBornDateTextBox.Text = author.BornDate;
            _innerForm.AuthorDiedDateTextBox.Text = author.DiedDate;
            _innerForm.AuthorBornLocationTextBox.Text = author.BornLocation;
        }

        protected override void LoadEntityListBox(int selectedIndex)
        {
            _entityListBox.Items.Clear();
            var allAuthorsNames = _authorService.GetAllAuthorsNames();
            Helper.LoadListBoxData(_entityListBox, allAuthorsNames, selectedIndex);
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }

            return Helper.CheckIfTextBoxesFilled(
                _innerForm.AuthorNameTextBox,
                _innerForm.AuthorDescriptionTextBox,
                _innerForm.AuthorBornDateTextBox,
                _innerForm.AuthorDiedDateTextBox,
                _innerForm.AuthorBornLocationTextBox);
        }

        protected override void DeleteEntityData()
        {
            var authorName = _entityListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);
            _authorService.Delete(author);
            LoadEntityListBox(0);
        }
    }
}
