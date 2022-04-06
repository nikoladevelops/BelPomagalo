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

            var form = new MainFormController(new MainForm()).Form;
            Application.Run(form);
            // TODO create methods for adding entities in the services
            // TODO wrap those methods inside the FormDataController
            // TODO create other controllers that use FormDataController, and make it so that each controller attaches event handlers for a form's events
        }
    }
}