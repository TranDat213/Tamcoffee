using TamCoffee.Gui;
using TamCoffee.Tests;

namespace TamCoffee
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
            // testDB.deleteSP(27);
            Application.Run(new formDangNhap());
        }
    }
}