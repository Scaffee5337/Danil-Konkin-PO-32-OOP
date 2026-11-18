using SmartHomeMasterConsole.Data;
using Microsoft.Data.Sqlite;

namespace SmartHomeMasterConsole
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
            using (var connection = DatabaseConnection.GetConnection())
            {
                connection.Open();
                MessageBox.Show("Подключение успешно");
            }
            Application.Run(new Form1());
        }
    }
}