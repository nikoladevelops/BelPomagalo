namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewOppositionForm : Form
    {
        public AddNewOppositionForm()
        {
            InitializeComponent();
        }
        public TextBox OppositionNameTextBox { get => oppositionNameTextBox; }
        public TextBox OppositionDescriptionTextBox { get => descriptionTextBox; }
        public Button AddNewOppositionButton { get => addNewOppositionButton; }
    }
}
