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
            var form = new MainFormController(new MainForm()).Form;

            Application.Run(form);
        }
    }
}