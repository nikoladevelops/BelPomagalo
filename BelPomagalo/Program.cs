using Microsoft.EntityFrameworkCore;

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
            Application.Run(new Form1());

            var db = new ApplicationDbContext();
            db.Database.Migrate();
            //TODO work on the design, create a PublishedWorks table contianing info about each author's published work
        }
    }
}