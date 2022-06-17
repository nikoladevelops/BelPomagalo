using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers.EditEntityControllers
{
    internal class EditCharacterFormController : EditEntityController
    {
        private readonly CharacterService _characterService;
        private readonly AuthorService _authorService;
        private readonly AddNewCharacterForm _innerForm;
        public EditCharacterFormController(EditForm form, AddNewCharacterForm innerForm, CharacterService characterService, AuthorService authorService) : base(form, innerForm)
        {
            _entityLabel.Text += "герой";
            _characterService = characterService;
            _authorService = authorService;
            _innerForm = innerForm;
            LoadAdditionalListBox(0);
            _additionalLabel.Text += "автор";
            _additionalLabel.Visible = true;
            _additionalListBox.Visible = true;
        }

        protected override async Task<bool> EditEntityData()
        {
            var authorName = _additionalListBox.SelectedItem.ToString();
            var authorToEdit = _authorService.GetAuthor(authorName);

            var characterName = _entityListBox.SelectedItem.ToString();
            var characterToEdit = _characterService.GetCharacter(characterName, authorToEdit);

            var newAuthor = _authorService.GetAuthor(_innerForm.AuthorListBox.SelectedItem.ToString());
            var newCharacterName = _innerForm.CharacterNameTextBox.Text;
            // if the author is not changed
            if (newAuthor.Id == authorToEdit.Id)
            {
                // make sure to display an error if the current author already owns a character with this name
                if (characterName != newCharacterName && _characterService.IsOwnedByAuthor(newCharacterName, newAuthor))
                {
                    MessageBox.Show("Вече съществува герой с такова име, направен от този автор.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            // if the author is changed
            else
            {
                // make sure to display an error if the new author already owns a character with this name
                if (_characterService.IsOwnedByAuthor(newCharacterName, newAuthor))
                {
                    MessageBox.Show("Вече съществува герой с такова име, направен от този автор.", "Грешка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            

            var changesToApply = new Character()
            {
                Name = _innerForm.CharacterNameTextBox.Text,
                Description = _innerForm.CharacterDescriptionTextBox.Text,
                AuthorId = newAuthor.Id
            };

            await _characterService.EditCharacter(characterToEdit, changesToApply);
            LoadAdditionalListBox(_innerForm.AuthorListBox.SelectedIndex);

            _entityListBox.SelectedIndex = _entityListBox.Items.IndexOf(changesToApply.Name);
            return true;
        }

        protected override void LoadEntityDataInAppropriateControls()
        {
            if (_additionalListBox.SelectedIndex == -1)
            {
                return;
            }

            if (_entityListBox.SelectedIndex == -1)
            {
                return;
            }

            var authorName = _additionalListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            var characterName = _entityListBox.SelectedItem.ToString();
            var character = _characterService.GetCharacter(characterName, author);

            _innerForm.CharacterNameTextBox.Text = character.Name;
            _innerForm.CharacterDescriptionTextBox.Text = character.Description;
            Helper.LoadListBoxData(_innerForm.AuthorListBox, _authorService.GetAllAuthorsNames(), _additionalListBox.SelectedIndex);
        }

        protected override void LoadEntityListBox(int selectedIndex)
        {
        }

        protected override bool ValidateEntityData()
        {
            if (_entityListBox.SelectedIndex == -1)
            {
                return false;
            }
            if (_additionalListBox.SelectedIndex == -1)
            {
                return false;
            }

            var newAuthorSelected = _innerForm.AuthorListBox.SelectedIndex != -1;
            return newAuthorSelected && Helper.CheckIfTextBoxesFilled(
                _innerForm.CharacterNameTextBox,
                _innerForm.CharacterDescriptionTextBox);
        }
        protected override void LoadAdditionalListBox(int selectedIndex)
        {
            _additionalListBox.Items.Clear();
            var allAuthorsNames = _authorService.GetAllAuthorsNames();
            Helper.LoadListBoxData(_additionalListBox, allAuthorsNames, selectedIndex);
        }
        protected override void LoadAdditionalDataInAppropriateControls()
        {
            if (_additionalListBox.SelectedIndex == -1)
            {
                return;
            }

            var authorName = _additionalListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            Helper.LoadListBoxData(_entityListBox, _characterService.GetAllCharactersNamesOfAuthor(author.Id));
        }

        protected override void DeleteEntityData()
        {
            var authorName = _additionalListBox.SelectedItem.ToString();
            var author = _authorService.GetAuthor(authorName);

            var characterName = _entityListBox.SelectedItem.ToString();
            var character = _characterService.GetCharacter(characterName, author);

            _characterService.Delete(character);
            LoadAdditionalListBox(0);
        }
    }
}
