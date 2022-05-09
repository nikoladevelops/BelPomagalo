namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewPublishedWorkForm : Form, IAddForm
    {
        public AddNewPublishedWorkForm()
        {
            InitializeComponent();
        }
        public TextBox NameTextBox { get => nameTextBox; }
        public TextBox PublishedDateTextBox { get => publishedDateTextBox; }
        public ListBox AuthorListBox { get => authorListBox; }
        public ListBox GenreListBox { get => genreListBox; }
        public ListBox ThemeListBox { get => themeListBox; }
        public ListBox CharacterListBox { get => characterListBox; }
        public TextBox CompositionTextBox { get => compositionTextBox; }
        public TextBox MotivesAndFiguresTextBox { get => motivesAndFiguresTextBox; }
        public ListBox OppositionListBox { get => oppositionListBox; }
        public TextBox IdeologicalSuggestionsTextBox { get => ideologicalSuggestionsTextBox; }
        public TextBox RemarksTextBox { get => remarksTextBox; }
        public Button AddButton { get => addPublishedWorkButton; }

        public Label AuthorLabel { get => authorLabel; }
        public Label GenreLabel { get => genreLabel; }
        public Label CompositionLabel { get => compositionLabel; }

    }
}
