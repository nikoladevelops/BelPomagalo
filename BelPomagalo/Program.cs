using BelPomagalo.Controllers;
using BelPomagalo.Services;
using Microsoft.EntityFrameworkCore;
using BelPomagalo.Views;

namespace BelPomagalo
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            SetUpMainForm();
        }
        private static async void SetUpMainForm() 
        {
            var db = new ApplicationDbContext();
            await db.Database.MigrateAsync();
            var form = new MainFormController(new MainForm(),
                new AuthorService(db),
                new GenreService(db),
                new ThemeService(db),
                new CharacterService(db),
                new OppositionService(db),
                new PublishedWorkService(db),
                new PublishedWorkGenreService(db),
                new PublishedWorkThemeService(db),
                new PublishedWorkCharacterService(db),
                new PublishedWorkOppositionService(db)).Form;

            Application.Run(form);
        }
    }
}