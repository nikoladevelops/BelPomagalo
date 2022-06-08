namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewQuestionChlenuvaneForm : Form, IAddForm
    {
        public AddNewQuestionChlenuvaneForm()
        {
            InitializeComponent();
        }
        public TextBox SentenceTextBox { get => sentenceTextBox; }
        public TextBox CorrectSentenceTextBox { get => correctSentenceTextBox; }
        public TextBox CorrectAnswersTextBox { get => correctAnswersTextBox; }
        public TextBox WrongAnswersTextBox { get => wrongAnswersTextBox; }
        public Button AddButton { get => addNewAuthorButton; }
    }
}
