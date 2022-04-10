namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewThemeForm : Form
    {
        public AddNewThemeForm()
        {
            InitializeComponent();
        }
        public TextBox ThemeNameTextBox { get => themeNameTextBox; }
        public TextBox ThemeDescriptionTextBox { get => descriptionTextBox; }
        public Button AddNewThemeButton { get => addNewThemeButton; }
    }
}
