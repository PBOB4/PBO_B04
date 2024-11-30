using TeaSMart_App;
using PROJEK;
using TeaSMart_App.Views;

namespace TeaSMart_App
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
            Application.Run(new HalamanUtama());
        }
    }
}

// di bagian design, mengatur winform default, jadi posisinya akan tetap ditengah