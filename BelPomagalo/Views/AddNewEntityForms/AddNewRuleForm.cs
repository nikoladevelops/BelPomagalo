namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewRuleForm : Form, IAddForm
    {
        public AddNewRuleForm()
        {
            InitializeComponent();
        }
        public TextBox RuleNameTextBox { get => ruleNameTextBox; }
        public TextBox RuleDescriptionTextBox { get => descriptionTextBox; }
        public Button AddButton { get => addNewAuthorButton; }
    }
}
