using BelPomagalo.Models;
using BelPomagalo.Utility;
using BelPomagalo.Views;

namespace BelPomagalo.Controllers
{
    internal class AddNewPublishedWorkFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewPublishedWorkForm _form;
        public AddNewPublishedWorkFormController(AddNewPublishedWorkForm form)
        {
            _controller = new FormDataController();
            _form = form;

            Helper.LoadListBoxData(_form.AuthorsListBox, _controller.GetAllAuthorsNames());
            Helper.LoadListBoxData(_form.GenreListBox, _controller.GetAllGenresNames(), false);
            Helper.LoadListBoxData(_form.ThemeListBox, _controller.GetAllThemesNames(), false);

            _form.AddPublishedWorkButton.Click += HandleAddPublishedWorkButtonClick;
        }
        public AddNewPublishedWorkForm Form { get => _form; }
        public async void HandleAddPublishedWorkButtonClick(object? sender, EventArgs e) 
        {
            var name = _form.NameTextBox.Text;
            var author = _controller.GetAuthor(_form.AuthorsListBox.SelectedItem.ToString());


            var genres = new List<Genre>();
            foreach (var selectedItem in _form.GenreListBox.SelectedItems)
            {
                var selectedGenre = _controller.GetGenre(selectedItem.ToString());
                genres.Add(selectedGenre);
            }

            var themes = new List<Theme>();
            foreach (var selectedItem in _form.ThemeListBox.SelectedItems)
            {
                var selectedTheme = _controller.GetTheme(selectedItem.ToString());
                themes.Add(selectedTheme);
            }

            var publishedWork = new PublishedWork()
            {
                Name = name,
                AuthorId = author.Id
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
