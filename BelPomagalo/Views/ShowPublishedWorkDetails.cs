namespace BelPomagalo.Views
{
    public partial class ShowPublishedWorkDetails : Form
    {
        public ShowPublishedWorkDetails()
        {
            InitializeComponent();
        }

        public ShowPublishedWorkDetails(string name, string authorName, IEnumerable<string> genreNames,IEnumerable<string> themeNames) : this()
        {
            nameLabel.Text = "Произведение: " + name;
            authorLabel.Text = "Автор: " + authorName;
            genreLabel.Text = "Жанр: " + string.Join(", ",genreNames);
            themeLabel.Text = "Теми: " + string.Join(", ",themeNames);
        }
    }
}
