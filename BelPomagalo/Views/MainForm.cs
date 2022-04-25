namespace BelPomagalo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Button HomeMenuButton { get => homeMenuButton; }
        public Button GamesMenuButton { get => gamesMenuButton; }
        public Button LibraryMenuButton { get => libraryMenuButton; }
        public Button ShowButton { get => showButton; }
        public Button AddNewPublishedWorkButton { get => addNewPublishedWorkButton; }
        public Button AddNewAuthorButton { get => addNewAuthorButton; }
        public Button AddNewGenreButton { get => addNewGenreButton; }
        public Button AddNewThemeButton { get => addNewThemeButton; }
        public Button AddNewCharacterButton { get => addNewCharacterButton; }
        public Button AddNewOppositionButton { get => addNewOppositionButton; }
        public ListBox AuthorsListBox { get => authorsListBox; }
        public ListBox PublishedWorksListBox { get => publishedWorkListBox; }
    }
}