namespace BelPomagalo.Views
{
    public partial class AddNewPublishedWorkForm : Form
    {
        public AddNewPublishedWorkForm()
        {
            InitializeComponent();
        }
        public ListBox AuthorsListBox { get => authorListBox; }
        public ListBox GenreListBox { get => genreListBox; }
        public ListBox ThemeListBox { get => themeListBox; }
        public Button AddPublishedWorkButton { get => addPublishedWorkButton; }
        public TextBox NameTextBox { get => nameTextBox; }
    }
}
