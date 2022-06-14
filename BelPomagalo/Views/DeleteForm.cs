namespace BelPomagalo.Views
{
    public partial class DeleteForm : Form
    {
        public DeleteForm()
        {
            InitializeComponent();
        }
        public ListBox EntityListBox { get => entityListBox; }
        public ListBox AdditionalListBox { get => additionalListBox; }
        public Panel EditPanel { get => editPanel; }
        public Label EntityLabel { get => entityLabel; }
        public Label AdditionalLabel { get => additionalLabel; }
    }
}
