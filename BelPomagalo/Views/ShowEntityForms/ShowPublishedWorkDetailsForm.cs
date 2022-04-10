namespace BelPomagalo.Views.ShowEntityForms
{
    public partial class ShowPublishedWorkDetailsForm : Form
    {
        public ShowPublishedWorkDetailsForm()
        {
            InitializeComponent();
        }

        public ShowPublishedWorkDetailsForm(string name, string authorName, IEnumerable<string> genreNames,IEnumerable<string> themeNames) : this()
        {
            nameLabel.Text = "Произведение: " + name;
            authorLabel.Text = "Автор: " + authorName;
            genreLabel.Text = "Жанр: " + string.Join(", ",genreNames);
            themeLabel.Text = "Теми: " + string.Join(", ",themeNames);
        }
    }
}
