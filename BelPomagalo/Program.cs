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

            // Ensure the database is created and if not create it
            using (var db = new ApplicationDbContext())
            {
                db.Database.Migrate();
            }

            Application.Run(new Form1());

        }
    }
}