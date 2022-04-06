using BelPomagalo.Models;
using BelPomagalo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BelPomagalo.Controllers
{
    internal class AddNewGenreFormController
    {
        private readonly FormDataController _controller;
        private readonly AddNewGenreForm _form;
        public AddNewGenreFormController(AddNewGenreForm form)
        {
            _controller = new FormDataController();
            _form = form;

            _form.AddNewGenreButton.Click += HandleAddNewGenreButtonClick;
        }
        public AddNewGenreForm Form { get => _form; }
        private async void HandleAddNewGenreButtonClick(object? sender, EventArgs e)
        {
            var genre = new Genre()
            {
                Name = _form.GenreNameTextBox.Text,
                Description = _form.GenreDescriptionTextBox.Text
            };
            await _controller.AddGenre(genre);
        }
    }
}
