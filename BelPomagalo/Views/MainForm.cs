using BelPomagalo.Controllers;
using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;

namespace BelPomagalo
{
    public partial class MainForm : Form
    {
        private readonly FormDataController _controller;
        public MainForm()
        {
            InitializeComponent();
            _controller = new FormDataController();
            Helper.LoadListBoxData(authorsListBox, _controller.GetAllAuthorsNames());

            if (authorsListBox.Items.Count>0)
            {
                var currentSelectedAuthorName = authorsListBox.SelectedItem.ToString();
                var author = _controller.GetAuthor(currentSelectedAuthorName);

                Helper.LoadListBoxData(publishedWorkListBox, _controller.GetPublishedWorksNames(author.Id));
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var publishedWork = _controller.GetPublishedWork(publishedWorkListBox.SelectedItem.ToString());
            var publishedWorkGenres = _controller.GetPublishedWorksGenres(publishedWork);
            var publishedWorkThemes = _controller.GetPublishedWorksThemes(publishedWork);

            var genreNames = new List<string>();
            foreach (var workGenre in publishedWorkGenres)
            {
                var pwGenre = _controller.GetGenre(workGenre.GenreId);
                genreNames.Add(pwGenre.Name);
            }

            var themeNames = new List<string>();
            foreach (var workTheme in publishedWorkThemes)
            {
                var pwTheme = _controller.GetTheme(workTheme.ThemeId);
                themeNames.Add(pwTheme.Name);
            }

            var publishedWorkForm = new ShowPublishedWorkDetails(publishedWork.Name, publishedWork.Author.Name, genreNames, themeNames);
            publishedWorkForm.Show();
        }

        private void SelectedAuthorChanged(object sender, EventArgs e)
        {
            var authorName = ((ListBox)sender).SelectedItem.ToString();
            
            var author = _controller.GetAuthor(authorName);
            Helper.LoadListBoxData(publishedWorkListBox, _controller.GetPublishedWorksNames(author.Id));
        }

        private void addNewPublishedWorkButton_Click(object sender, EventArgs e)
        {
            var addNewPublishedWorkForm = new AddNewPublishedWork();
            addNewPublishedWorkForm.Show();
        }
    }
}