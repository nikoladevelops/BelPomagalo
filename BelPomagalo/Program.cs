using BelPomagalo.Controllers;
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
            var addNewPublishedWorkForm = new AddNewPublishedWorkFormController(new AddNewPublishedWorkForm()).Form;
            var addNewAuthorForm = new AddNewAuthorForm();
            var addNewGenreForm = new AddNewGenreForm();
            var addNewThemeForm= new AddNewThemeForm();

            var form = new MainFormController(new MainForm(), addNewPublishedWorkForm, addNewAuthorForm, addNewGenreForm, addNewThemeForm).Form;


            Application.Run(form);
        }
    }
}