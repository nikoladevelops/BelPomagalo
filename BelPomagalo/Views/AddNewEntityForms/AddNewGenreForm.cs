namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewGenreForm : Form, IAddForm
    {
        public AddNewGenreForm()
        {
            InitializeComponent();
        }
        public TextBox GenreNameTextBox { get => genreNameTextBox; }
        public TextBox GenreDescriptionTextBox { get => descriptionTextBox; }
        public Button AddButton { get => addNewGenreButton; }
    }
}
