namespace BelPomagalo.Views.AddNewEntityForms
{
    public partial class AddNewThemeForm : Form,IAddForm
    {
        public AddNewThemeForm()
        {
            InitializeComponent();
        }
        public TextBox ThemeNameTextBox { get => themeNameTextBox; }
        public TextBox ThemeDescriptionTextBox { get => descriptionTextBox; }
        public Button AddButton { get => addNewThemeButton; }

    }
}
