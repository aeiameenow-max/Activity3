using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using Microsoft.Data.SqlClient;

namespace activity_finals
{
    public static class Db
    {
        private const string ConnectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=activity_finals;Integrated Security=True;TrustServerCertificate=True;";

        public static bool UsernameExists(string username)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            using var cmd = new SqlCommand("SELECT COUNT(*) FROM users WHERE username = @u", conn);
            cmd.Parameters.AddWithValue("@u", username);

            return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
        }

        public static void CreateUser(string username, string password)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            using var cmd = new SqlCommand(
                "INSERT INTO users (username, password_hash) VALUES (@u, @p)", conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", Hash(password));
            cmd.ExecuteNonQuery();
        }

        public static bool ValidateUser(string username, string password)
        {
            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            using var cmd = new SqlCommand(
                "SELECT password_hash FROM users WHERE username = @u", conn);
            cmd.Parameters.AddWithValue("@u", username);

            string stored = cmd.ExecuteScalar() as string;
            return stored != null && stored == Hash(password);
        }

        public static List<object[]> GetProducts()
        {
            var rows = new List<object[]>();

            using var conn = new SqlConnection(ConnectionString);
            conn.Open();

            using var cmd = new SqlCommand(
                "SELECT id, product_name, category, date_added, stock, price FROM products ORDER BY id", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                rows.Add(new object[]
                {
                    reader.GetInt32(0).ToString("000"),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetDateTime(3).ToString("yyyy-MM-dd"),
                    reader.GetInt32(4).ToString(),
                    "\u20B1" + reader.GetDecimal(5).ToString("#,##0")
                });
            }

            return rows;
        }

        public static string Hash(string text)
        {
            using var sha = SHA256.Create();
            byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(text));
            return Convert.ToBase64String(bytes);
        }
    }
}