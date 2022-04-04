using BelPomagalo.Controllers;
using BelPomagalo.Models;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BelPomagalo.Views
{
    public partial class AddNewPublishedWork : Form
    {
        private readonly FormDataController _controller;
        public AddNewPublishedWork()
        {
            InitializeComponent();
            _controller = new FormDataController();

            Helper.LoadListBoxData(authorListBox, _controller.GetAllAuthorsNames());
            Helper.LoadListBoxData(genreListBox, _controller.GetAllGenresNames(), false);
            Helper.LoadListBoxData(themeListBox, _controller.GetAllThemesNames(), false);
        }

        private async void addPublishedWorkButton_Click(object sender, EventArgs e)
        {
            var name = nameTextBox.Text;
            var author = _controller.GetAuthor(authorListBox.SelectedItem.ToString());


            var genres = new List<Genre>();
            foreach (var selectedItem in genreListBox.SelectedItems)
            {
                var selectedGenre = _controller.GetGenre(selectedItem.ToString());
                genres.Add(selectedGenre);
            }

            var themes = new List<Theme>();
            foreach (var selectedItem in themeListBox.SelectedItems)
            {
                var selectedTheme = _controller.GetTheme(selectedItem.ToString());
                themes.Add(selectedTheme);
            }

            var publishedWork = new PublishedWork()
            {
                Name=name,
                AuthorId=author.Id
            };

            publishedWork = await _controller.AddPublishedWork(publishedWork);

            foreach (var genre in genres)
            {
                await _controller.AddPublishedWorkGenre(new PublishedWorkGenre() { PublishedWorkId = publishedWork.Id, GenreId = genre.Id });
            }

            foreach (var theme in themes)
            {
                await _controller.AddPublishedWorkTheme(new PublishedWorkTheme() { PublishedWorkId = publishedWork.Id, ThemeId = theme.Id });
            }
        }
    }
}
