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


            LoadAllAuthors();

            authorsListBox.SelectedIndex = 0;
            var currentSelectedAuthorName = authorsListBox.SelectedItem.ToString();
            var currentAuthor = _authorService.GetAuthor(currentSelectedAuthorName);

            if (currentAuthor!=null)
            {
                LoadAuthorPublishedWorks(currentAuthor.Id);
            }

        }

        private void LoadAllAuthors()
        {
            var allAuthors = _authorService.GetAllAuthors();
            if (allAuthors != null)
            {
                foreach (var author in allAuthors)
                {
                    authorsListBox.Items.Add(author.Name);
                }
            }
        }

        private void LoadAuthorPublishedWorks(int authorId)
        {
            var currentAuthorPublishedWorks = _publishedWorkService.GetPublishedWorksOfAuthor(authorId);

            if (currentAuthorPublishedWorks != null)
            {
                foreach (var publishedWork in currentAuthorPublishedWorks)
                {
                    publishedWorkListBox.Items.Add(publishedWork.Name);
                }
            }
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            // TODO open a form that displays the current published work's data
        }

        private void SelectedAuthorChanged(object sender, EventArgs e)
        {
            var authorName = ((ListBox)sender).SelectedItem.ToString();

        }
    }
}