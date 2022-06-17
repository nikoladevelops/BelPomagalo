namespace BelPomagalo.Views
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }
        public ListBox EntityListBox { get => entityListBox; }
        public ListBox AdditionalListBox { get => additionalListBox; }
        public Panel EditPanel { get => editPanel; }
        public Label EntityLabel { get => entityLabel; }
        public Label AdditionalLabel { get => additionalLabel; }
        public Button DeleteButton { get => deleteButton; }
    }
}
