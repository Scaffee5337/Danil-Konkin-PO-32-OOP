using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Data.Sqlite;

namespace SmartHomeMasterConsole.Data
{
    public static class DatabaseConnection
    {
        private static readonly string DatabasePath = Path.Combine(AppContext.BaseDirectory, "smart_home.db");
        private static readonly string ConnectionString = $"Data Source={DatabasePath};Foreign Keys=True;";
        public static SqliteConnection GetConnection()
        {
            return new SqliteConnection(ConnectionString);
        }
    }
}
