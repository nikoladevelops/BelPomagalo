namespace BelPomagalo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public Panel ContentPanel { get => contentPanel; }
        public Button HomeMenuButton { get => homeMenuButton; }
        public Button GamesMenuButton { get => gamesMenuButton; }
        public Button LibraryMenuButton { get => libraryMenuButton; }
    }
}