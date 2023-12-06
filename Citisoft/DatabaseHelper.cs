using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace Citisoft
{

    public class DatabaseHelper
    {
        private string _connectionString;

        public DatabaseHelper(string dbPath)
        {
            _connectionString = $"Data Source={dbPath};Version=3;";
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                InitializeDatabase();
            }
        }

        private void InitializeDatabase()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "CREATE TABLE Messages (Id INTEGER PRIMARY KEY AUTOINCREMENT, MessageText TEXT NOT NULL, Timestamp TEXT NOT NULL)";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.ExecuteNonQuery();
            }
        }

        public void AddMessage(string message, string timestamp)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "INSERT INTO Messages (MessageText, Timestamp) VALUES (@Message, @Timestamp)";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@Message", message);
                command.Parameters.AddWithValue("@Timestamp", timestamp);
                command.ExecuteNonQuery();
            }
        }

        public List<(string Message, string Timestamp)> GetAllMessages()
        {
            var messages = new List<(string Message, string Timestamp)>();
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT MessageText, Timestamp FROM Messages";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        messages.Add((reader["MessageText"].ToString(), reader["Timestamp"].ToString()));
                    }
                }
            }
            return messages;
        }

        public void DeleteMessage(string message, string timestamp)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Messages WHERE MessageText = @Message AND Timestamp = @Timestamp";
                SQLiteCommand command = new SQLiteCommand(sql, conn);
                command.Parameters.AddWithValue("@Message", message);
                command.Parameters.AddWithValue("@Timestamp", timestamp);
                command.ExecuteNonQuery();
            }
        }
    }
}
