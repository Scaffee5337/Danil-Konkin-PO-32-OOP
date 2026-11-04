using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.Sqlite;
using ClinicCRM.Interfaces;

namespace ClinicCRM.Repositories.Sqlite
{
    namespace ClinicCRM.Repositories.Sqlite
    {
        public class SqliteRepository<T> : IRepository<T> where T : class
        {
            private readonly string _connectionString;
            private readonly string _selectAllSql;
            private readonly string _selectByIdSql;
            private readonly string _insertSql;
            private readonly Func<SqliteDataReader, T> _mapper;
            private readonly Action<SqliteCommand, T> _configureInsert;
            public SqliteRepository(string connectionString, string selectAllSql, string selectByIdSql, string insertSql, Func<SqliteDataReader, T> mapper, 
                Action<SqliteCommand, T> configureInsert)
            {
                _connectionString = connectionString;
                _selectAllSql = selectAllSql;
                _selectByIdSql = selectByIdSql;
                _insertSql = insertSql;
                _mapper = mapper;
                _configureInsert = configureInsert;
            }

            private SqliteConnection CreateConnection()
            {
                var connection = new SqliteConnection(_connectionString);
                connection.Open();
                using var command = connection.CreateCommand();
                command.CommandText = "PRAGMA foreign_keys = ON;";
                command.ExecuteNonQuery();
                return connection;
            }
            public List<T> GetAll()
            {
                List<T> items = new();
                using var connection = CreateConnection();
                using var command = connection.CreateCommand();
                command.CommandText = _selectAllSql;
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    items.Add(_mapper(reader));
                }
                return items;
            }
            public T GetById(int id)
            {
                using var connection = CreateConnection();
                using var command = connection.CreateCommand();
                command.CommandText = _selectByIdSql;
                command.Parameters.AddWithValue("@Id", id);
                using var reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return _mapper(reader);
                }
                throw new KeyNotFoundException($"Объект типа {typeof(T).Name} с ID {id} не найден.");
            }
            public void Add(T item)
            {
                ArgumentNullException.ThrowIfNull(item);
                using var connection = CreateConnection();
                using var command = connection.CreateCommand();
                command.CommandText = _insertSql;
                _configureInsert(command, item);
                command.ExecuteNonQuery();
            }
        }
    }
}
