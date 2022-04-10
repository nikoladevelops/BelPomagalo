namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewCharacterForm : Form, IAddForm
    {
        public AddNewCharacterForm()
        {
            InitializeComponent();
        }
        public TextBox CharacterNameTextBox { get => characterNameTextBox; }
        public TextBox CharacterDescriptionTextBox { get => descriptionTextBox; }
        public ListBox AuthorListBox { get => authorListBox; }
        public Button AddButton { get => addNewCharacterButton; }
    }
}
