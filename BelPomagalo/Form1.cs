using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Views;
using Microsoft.EntityFrameworkCore;

namespace BelPomagalo
{
    public partial class Form1 : Form
    {
        private readonly ApplicationDbContext _context;
        private readonly AuthorService _authorService;
        private readonly PublishedWorkService _publishedWorkService;
        public Form1()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
            _context.Database.Migrate();

            _authorService = new AuthorService(_context);
            _publishedWorkService = new PublishedWorkService(_context);

            LoadListBoxData(authorsListBox, _authorService.GetAllAuthorsNames());

            if (authorsListBox.Items.Count>0)
            {
                var currentSelectedAuthorName = authorsListBox.SelectedItem.ToString();
                var author = _authorService.GetAuthor(currentSelectedAuthorName);

                LoadListBoxData(publishedWorkListBox, _publishedWorkService.GetPublishedWorksNames(author.Id));
            }
        }

        private void LoadListBoxData(ListBox listBox, IEnumerable<string> data) 
        {
            listBox.Items.Clear();

            if (data != null)
            {
                foreach (var item in data)
                {
                    listBox.Items.Add(item);
                }
                listBox.SelectedIndex = 0;
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            var publishedWork = _publishedWorkService.GetPublishedWork(publishedWorkListBox.SelectedItem.ToString());

            var publishedWorkForm = new ShowPublishedWorkDetails(publishedWork.Name, publishedWork.Genre.Name, publishedWork.Author.Name, publishedWork.Theme.Name);
            publishedWorkForm.Show();
        }

        private void SelectedAuthorChanged(object sender, EventArgs e)
        {
            var authorName = ((ListBox)sender).SelectedItem.ToString();
            
            var author = _authorService.GetAuthor(authorName);
            LoadListBoxData(publishedWorkListBox,_publishedWorkService.GetPublishedWorksNames(author.Id));
        }
    }
}