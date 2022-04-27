﻿using BelPomagalo.Controllers.AddNewEntityControllers;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers
{
    internal class LibraryFormController : Controller<LibraryForm>
    {
        private readonly AuthorService _authorService;
        private readonly GenreService _genreService;
        private readonly ThemeService _themeService;
        private readonly CharacterService _characterService;
        private readonly OppositionService _oppositionService;
        private readonly PublishedWorkService _publishedWorkService;
        private readonly PublishedWorkGenreService _publishedWorkGenreService;
        private readonly PublishedWorkThemeService _publishedWorkThemeService;
        private readonly PublishedWorkCharacterService _publishedWorkCharacterService;
        private readonly PublishedWorkOppositionService _publishedWorkOppositionService;

        private readonly string[] literatureComboBoxItems = new string[] { "автор", "герой", "жанр", "опозиция", "произведение", "тема" };
        private readonly string[] bulgarianComboBoxItems = new string[] {  }; // TODO

        public LibraryFormController(LibraryForm form, AuthorService authorService, GenreService genreService, ThemeService themeService,
            CharacterService characterService, OppositionService oppositionService, PublishedWorkService publishedWorkService,
            PublishedWorkGenreService publishedWorkGenreService, PublishedWorkThemeService publishedWorkThemeService,
            PublishedWorkCharacterService publishedWorkCharacterService, PublishedWorkOppositionService publishedWorkOppositionService) : base(form)
        {
            _authorService = authorService;
            _genreService = genreService;
            _themeService = themeService;
            _characterService = characterService;
            _oppositionService = oppositionService;
            _publishedWorkService = publishedWorkService;
            _publishedWorkGenreService = publishedWorkGenreService;
            _publishedWorkThemeService = publishedWorkThemeService;
            _publishedWorkCharacterService = publishedWorkCharacterService;
            _publishedWorkOppositionService = publishedWorkOppositionService;

            _form.Load += HandleFormLoad;

            _form.LiteratureAddButton.Click += HandleAddNewLiteratureEntity;
            _form.LiteratureEditButton.Click += HandleEditLiteratureEntity;
            _form.LiteratureDeleteButton.Click += HandleDeleteLiteratureEntity;

            _form.BulgarianAddButton.Click += HandleAddNewBulgarianEntity;
            _form.BulgarianEditButton.Click += HandleEditBulgarianEntity;
            _form.BulgarianDeleteButton.Click += HandleDeleteBulgarianEntity;
        }

        private void HandleFormLoad(object? sender, EventArgs e)
        {
            Helper.LoadComboBoxData(_form.LiteratureComboBox, literatureComboBoxItems);
            Helper.LoadComboBoxData(_form.BulgarianComboBox, bulgarianComboBoxItems);
        }

        private void HandleDeleteBulgarianEntity(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleEditBulgarianEntity(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleAddNewBulgarianEntity(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleAddNewLiteratureEntity(object? sender, EventArgs e)
        {
            OpenLiteratureFormDependingOnSelectedEntity("add");
        }
        private void HandleEditLiteratureEntity(object? sender, EventArgs e)
        {
            OpenLiteratureFormDependingOnSelectedEntity("edit");
        }
        private void HandleDeleteLiteratureEntity(object? sender, EventArgs e)
        {
            OpenLiteratureFormDependingOnSelectedEntity("delete");
        }

        private void OpenLiteratureFormDependingOnSelectedEntity(string formType)
        {
            var selectedLiteratureEntity = _form.LiteratureComboBox.SelectedItem.ToString();
            if (selectedLiteratureEntity == null)
            {
                MessageBox.Show("Трябва да изберете какво искате да промените.");
                return;
            }

            switch (selectedLiteratureEntity)
            {
                case "автор":
                    OpenChildFormDependingOnFormType(formType,
                        new AddNewAuthorFormController(new AddNewAuthorForm(), _authorService).Form, new Form(), new Form());
                    break;
                case "герой":
                    OpenChildFormDependingOnFormType(formType,
                        new AddNewCharacterFormController(new AddNewCharacterForm(), _characterService, _authorService).Form, new Form(), new Form());
                    break;
                case "жанр":
                    OpenChildFormDependingOnFormType(formType,
                        new AddNewGenreFormController(new AddNewGenreForm(), _genreService).Form, new Form(), new Form());
                    break;
                case "опозиция":
                    OpenChildFormDependingOnFormType(formType,
                        new AddNewOppositionFormController(new AddNewOppositionForm(), _oppositionService).Form, new Form(), new Form());
                    break;
                case "произведение":
                    OpenChildFormDependingOnFormType(formType,
                        new AddNewPublishedWorkFormController(new AddNewPublishedWorkForm(),
                        _authorService,
                        _genreService,
                        _themeService,
                        _characterService,
                        _oppositionService,
                        _publishedWorkService,
                        _publishedWorkGenreService,
                        _publishedWorkThemeService,
                        _publishedWorkCharacterService,
                        _publishedWorkOppositionService).Form, new Form(), new Form());
                    break;
                case "тема":
                    OpenChildFormDependingOnFormType(formType,
                        new AddNewThemeFormController(new AddNewThemeForm(), _themeService).Form, new Form(), new Form());
                    break;
                default:
                    break;
            }
        }
        private void OpenChildFormDependingOnFormType(string formType, Form addEntityForm, Form editEntityForm, Form deleteEntityForm) 
        {
            if (formType == "add")
            {
                addEntityForm.Show();

                editEntityForm.Dispose();
                deleteEntityForm.Dispose();
            }
            else if (formType == "edit")
            {
                editEntityForm.Show();

                addEntityForm.Dispose();
                deleteEntityForm.Dispose();
            }
            else if (formType == "delete")
            {
                deleteEntityForm.Show();

                editEntityForm.Dispose();
                addEntityForm.Dispose();
            }
        }
    }
}
