using Assignment_10._3._1;
using Microsoft.EntityFrameworkCore;

namespace Assignment_10._3._1
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

            Records.context = new CarContext();
            Records.context.Database.EnsureCreated();
            Records.context.Cars.Load();

            Application.Run(new Form1());
        }
    }
}