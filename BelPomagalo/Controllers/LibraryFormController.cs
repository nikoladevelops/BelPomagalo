using BelPomagalo.Controllers.AddNewEntityControllers;
using BelPomagalo.Controllers.EditEntityControllers;
using BelPomagalo.Services;
using BelPomagalo.Utility;
using BelPomagalo.Views;
using BelPomagalo.Views.AddNewEntityForms;

namespace BelPomagalo.Controllers
{
    internal class LibraryFormController : Controller<LibraryForm>
    {
        private readonly Action<Form> _openChildFormMethod;
        private readonly ApplicationDbContext _context;

        private readonly string[] literatureComboBoxItems = new string[] { "автор", "герой", "жанр", "опозиция", "произведение", "тема" };
        private readonly string[] bulgarianComboBoxItems = new string[] {  "граматично правило", "правописно правило", "пунктуационно правило", "задача за членуване"};

        public LibraryFormController(LibraryForm form, Action<Form> openChildFormMethod, ApplicationDbContext context) : base(form)
        {
            _context = context;
            _openChildFormMethod=openChildFormMethod;

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

        // TODO ALL OF THIS
        private void HandleDeleteBulgarianEntity(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void HandleEditBulgarianEntity(object? sender, EventArgs e)
        {
            Form formToOpen = null;
            switch (_form.BulgarianComboBox.SelectedItem)
            {
                case "граматично правило":
                    //TODO
                    break;
                case "правописно правило":
                    
                    break;
                case "пунктуационно правило":
                   
                    break;
                case "задача за членуване":
                    
                    break;
                default:
                    break;
            }
            _openChildFormMethod(formToOpen);
        }

        private void HandleAddNewBulgarianEntity(object? sender, EventArgs e)
        {
            Form formToOpen = null;
            switch (_form.BulgarianComboBox.SelectedItem)
            {
                case "граматично правило":
                    formToOpen = new AddNewGrammarRuleFormController(
                        new AddNewRuleForm(),
                        new GrammarRuleService(_context)
                        ).Form;
                    break;
                case "правописно правило":
                    formToOpen = new AddNewWritingRuleFormController(
                        new AddNewRuleForm(),
                        new WritingRuleService(_context)
                        ).Form;
                    break;
                case "пунктуационно правило":
                    formToOpen = new AddNewPunctuationRuleFormController(
                        new AddNewRuleForm(),
                        new PunctuationRuleService(_context)
                        ).Form;
                    break;
                case "задача за членуване":
                    formToOpen = new AddNewQuestionChlenuvaneFormController(
                        new AddNewQuestionChlenuvaneForm(),
                        new QuestionChlenuvaneService(_context)
                        ).Form;
                    break;
                default:
                    break;
            }
            _openChildFormMethod(formToOpen);
        }

        private void HandleAddNewLiteratureEntity(object? sender, EventArgs e)
        {
            ShowAddEntityForm();
        }
        private void HandleEditLiteratureEntity(object? sender, EventArgs e)
        {
            ShowEditEntityForm();
        }
        private void HandleDeleteLiteratureEntity(object? sender, EventArgs e)
        {
            ShowDeleteEntityForm();
        }
        private void ShowAddEntityForm()
        {
            Form formToOpen = null;
            switch (_form.LiteratureComboBox.SelectedItem)
            {
                case "автор":
                    formToOpen = new AddNewAuthorFormController(
                        new AddNewAuthorForm(),
                        new AuthorService(_context)
                        ).Form;
                    break;
                case "герой":
                    formToOpen = new AddNewCharacterFormController(
                        new AddNewCharacterForm(),
                        new CharacterService(_context),
                        new AuthorService(_context)
                        ).Form;
                    break;
                case "жанр":
                    formToOpen = new AddNewGenreFormController(
                        new AddNewGenreForm(),
                        new GenreService(_context)
                        ).Form;
                    break;
                case "опозиция":
                    formToOpen = new AddNewOppositionFormController(
                        new AddNewOppositionForm(),
                        new OppositionService(_context)
                        ).Form;
                    break;
                case "произведение":
                    formToOpen = new AddNewPublishedWorkFormController(
                        new AddNewPublishedWorkForm(),
                        new AuthorService(_context),
                        new GenreService(_context),
                        new ThemeService(_context),
                        new CharacterService(_context),
                        new OppositionService(_context),
                        new PublishedWorkService(_context),
                        new PublishedWorkGenreService(_context),
                        new PublishedWorkThemeService(_context),
                        new PublishedWorkCharacterService(_context),
                        new PublishedWorkOppositionService(_context)
                        ).Form;
                    break;
                case "тема":
                    formToOpen = new AddNewThemeFormController(
                        new AddNewThemeForm(),
                        new ThemeService(_context)
                        ).Form;
                    break;
                default:
                    break;
            }
            _openChildFormMethod(formToOpen);
        }
        private void ShowEditEntityForm() 
        {
            Form formToOpen = null;
            switch (_form.LiteratureComboBox.SelectedItem)
            {
                case "автор":
                    formToOpen = new EditAuthorFormController(
                        new EditForm(),
                        new AddNewAuthorForm(),
                        new AuthorService(_context)
                        ).Form;
                    break;
                case "герой":
                    formToOpen = new EditCharacterFormController(
                        new EditForm(),
                        new AddNewCharacterForm(),
                        new CharacterService(_context),
                        new AuthorService(_context)
                        ).Form;
                    break;
                case "жанр":
                    formToOpen = new EditGenreFormController(
                        new EditForm(),
                        new AddNewGenreForm(),
                        new GenreService(_context)
                        ).Form;
                    break;
                case "опозиция":
                    formToOpen = new EditOppositionFormController(
                        new EditForm(),
                        new AddNewOppositionForm(),
                        new OppositionService(_context)
                        ).Form;
                    break;
                case "произведение":
                    formToOpen = new EditPublishedWorkFormController(
                        new EditForm(),
                        new AddNewPublishedWorkForm(),
                        new AuthorService(_context),
                        new GenreService(_context),
                        new ThemeService(_context),
                        new CharacterService(_context),
                        new OppositionService(_context),
                        new PublishedWorkService(_context),
                        new PublishedWorkGenreService(_context),
                        new PublishedWorkThemeService(_context),
                        new PublishedWorkCharacterService(_context),
                        new PublishedWorkOppositionService(_context)
                        ).Form;
                    break;
                case "тема":
                    formToOpen = new EditThemeFormController(
                        new EditForm(),
                        new AddNewThemeForm(),
                        new ThemeService(_context)
                        ).Form;
                    break;
                default:
                    break;
            }
            _openChildFormMethod(formToOpen);
        }
        private void ShowDeleteEntityForm()
        {

        }
    }
}
