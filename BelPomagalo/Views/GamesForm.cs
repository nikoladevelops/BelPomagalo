namespace BelPomagalo.Views
{
    public partial class GamesForm : Form
    {
        public GamesForm()
        {
            InitializeComponent();
        }

        public Button GuessGenreButton { get => guessGenreButton; }
        public Button GuessAuthorButton { get => guessAuthorButton; }
        public Button GuessThemesButton { get => guessThemesButton; }
        public Button GuessContextButton { get => guessContextButton; }
        public Button RemindPublishedWorksButton { get => remindPublishedWorksButton; }
        public Button ChlenuvaiButton { get => chlenuvaiButton; }
        public Button RemindGrammarRulesButton { get => remindGrammarRulesButton; }
        public Button RemindWritingRulesButton { get => remindWritingRulesButton; }
        public Button RemindPunctuationRulesButton { get => remindPunctuationRulesButton; }
    }
}
