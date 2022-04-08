namespace BelPomagalo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Button ShowButton { get => showButton; }
        public Button AddNewPublishedWorkButton { get => addNewPublishedWorkButton; }
        public Button AddNewAuthorButton { get => addNewAuthorButton; }
        public Button AddNewGenreButton { get => addNewGenreButton; }
        public Button AddNewThemeButton { get => addNewThemeButton; }
        public Button AddNewCharacterButton { get => addNewCharacterButton; }
        public ListBox AuthorsListBox { get => authorsListBox; }
        public ListBox PublishedWorksListBox { get => publishedWorkListBox; }
    }
}