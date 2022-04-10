namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewAuthorForm : Form, IAddForm
    {
        public AddNewAuthorForm()
        {
            InitializeComponent();
        }
        public TextBox AuthorNameTextBox { get => authorNameTextBox; }
        public TextBox AuthorDescriptionTextBox { get => descriptionTextBox; }
        public TextBox AuthorBornLocationTextBox { get => bornLocationTextBox; }
        public TextBox AuthorBornDateTextBox { get => bornDateTextBox; }
        public TextBox AuthorDiedDateTextBox { get => diedDateTextBox; }
        public Button AddButton { get => addNewAuthorButton; }
    }
}
