namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewGenreForm : Form
    {
        public AddNewGenreForm()
        {
            InitializeComponent();
        }
        public TextBox GenreNameTextBox { get => genreNameTextBox; }
        public TextBox GenreDescriptionTextBox { get => descriptionTextBox; }
        public Button AddNewGenreButton { get => addNewGenreButton; }
    }
}
