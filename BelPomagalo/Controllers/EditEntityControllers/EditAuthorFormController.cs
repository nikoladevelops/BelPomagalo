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

        protected override void EditEntityData()
        {
            var authorName = _entityListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            var changesToApply = new Author()
            {
                Name = _innerForm.AuthorNameTextBox.Text,
                Description = _innerForm.AuthorDescriptionTextBox.Text,
                BornDate = _innerForm.AuthorBornDateTextBox.Text,
                DiedDate = _innerForm.AuthorDiedDateTextBox.Text,
                BornLocation = _innerForm.AuthorBornLocationTextBox.Text
            };

            _authorService.EditAuthor(author, changesToApply);

            LoadEntityListBox(_entityListBox.SelectedIndex);
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
    }
}
