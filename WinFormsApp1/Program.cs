using Recognize.Views;


namespace Recognize
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string curFile = @"c:\temp\db.xlsx";
            string exampleXLSX = @"..\..\..\..\db.xlsx";
            if (!File.Exists(curFile))
                File.Copy(exampleXLSX, curFile);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new AuthView());
        }
    }
}