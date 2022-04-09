namespace BelPomagalo.Views
{
    public partial class AddNewCharacterForm : Form
    {
        public AddNewCharacterForm()
        {
            InitializeComponent();
        }
        public TextBox CharacterNameTextBox { get => characterNameTextBox; }
        public TextBox CharacterDescriptionTextBox { get => descriptionTextBox; }
        public ListBox AuthorListBox { get => authorListBox; }
        public Button AddNewCharacterButton { get => addNewCharacterButton; }
    }
}
