using Dapper;
using KasirPBO.res.Model;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirPBO
{
    public class SqliteDataAccess
    {
        private static readonly string dbPath = Path.Combine(AppContext.BaseDirectory, "kasir.db");
        private static readonly string connectionString = $"Data Source={dbPath}";

        public static void InitializeDatabase()
        {
            // Pastikan file kasir.db akan dibuat jika belum ada (SQLite akan otomatis buat saat pertama koneksi)
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                // SQL create tables
                string createUsersTable = @"
                CREATE TABLE IF NOT EXISTS users (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    username TEXT NOT NULL,
                    password TEXT NOT NULL,
                    level TEXT NOT NULL,
                    display_name TEXT NOT NULL
                );";

                string createProductsTable = @"
                CREATE TABLE IF NOT EXISTS products (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    code TEXT NOT NULL UNIQUE,
                    name TEXT NOT NULL,
                    price REAL NOT NULL,
                    quantity INTEGER NOT NULL
                );";

                string createTransactionsTable = @"
                CREATE TABLE IF NOT EXISTS transactions (
                    id INTEGER PRIMARY KEY AUTOINCREMENT,
                    items TEXT NOT NULL, -- bisa JSON string
                    total INTEGER NOT NULL,
                    money INTEGER NOT NULL,
                    changes INTEGER NOT NULL,
                    user_id INTEGER NOT NULL,
                    timestamp DATETIME DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY(user_id) REFERENCES users(id)
                );";

                // Eksekusi
                conn.Execute(createUsersTable);
                conn.Execute(createProductsTable);
                conn.Execute(createTransactionsTable);

            }

            DBSeeder();
        }

        private static void DBSeeder()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();

                // Seeder: Users
                int userCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM users");
                if (userCount == 0)
                {
                    string hashedPassword = PasswordHelper.HashPassword("12345678");

                    conn.Execute(@"INSERT INTO users (username, password, level, display_name)
                           VALUES ('admin', @password, '0', 'Admin')", new { password = hashedPassword });

                    conn.Execute(@"INSERT INTO users (username, password, level, display_name)
                           VALUES ('kasir1', @password, '1', 'Kasir 1')", new { password = hashedPassword });
                }

                // Seeder: Products
                int productCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM products");
                if (productCount == 0)
                {
                    conn.Execute(@"
                INSERT INTO products (code, name, price, quantity) VALUES
                ('D001', 'Kopi Hitam', 5000, 50),
                ('D002', 'Teh Manis', 4000, 30),
                ('F001', 'Roti Bakar', 8000, 20);
            ");
                }

                // Seeder: Transactions (dummy)
            //    int transCount = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM transactions");
            //    if (transCount == 0)
            //    {
            //        string dummyItemsJson = "[{\"product_id\":1,\"qty\":2,\"price\":5000},{\"product_id\":2,\"qty\":1,\"price\":4000}]";

            //        conn.Execute(@"
            //    INSERT INTO transactions (items, user_id)
            //    VALUES (@Items, @UserId);
            //", new { Items = dummyItemsJson, UserId = 1 });
            //    }
            }
        }

        public static List<UserModel> LoadUser()
        {
            using (IDbConnection conn = new SqliteConnection(LoadConnectionString()))
            {
                var output = conn.Query<UserModel>("SELECT * FROM users", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SaveUser(UserModel user)
        {
            using (IDbConnection conn = new SqliteConnection(LoadConnectionString()))
            {
                conn.Execute("INSERT INTO users (username, password, level, display_name) VALUES (@username, @password, @level, @display_name)", user);
            }
        }

        public static void UpdateUserByUsername(UserModel user)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Execute(@"UPDATE users 
                       SET password = @password, 
                           level = @level, 
                           display_name = @display_name 
                       WHERE username = @username", user);
            }
        }

        public static bool IsUsernameExists(string username)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                var result = conn.ExecuteScalar<int>(
                    "SELECT COUNT(*) FROM users WHERE username = @username",
                    new { username });
                return result > 0;
            }
        }

        public static void DeleteUserById(int id)
        {
            using (IDbConnection conn = new SqliteConnection(connectionString))
            {
                conn.Execute("DELETE FROM users WHERE id = @id", new { id });
            }
        }

        public static List<ProductModel> LoadProducts()
        {
            using (IDbConnection conn = new SqliteConnection(connectionString))
            {
                var output = conn.Query<ProductModel>("SELECT * FROM products", new DynamicParameters());
                return output.ToList();
            }
        }

        public static bool IsProductCodeExists(string code)
        {
            using (IDbConnection conn = new SqliteConnection(LoadConnectionString()))
            {
                var result = conn.ExecuteScalar<int>("SELECT COUNT(*) FROM products WHERE code = @code", new { code });
                return result > 0;
            }
        }


        public static void saveProduct(ProductModel product)
        {
            using (IDbConnection conn = new SqliteConnection(LoadConnectionString()))
            {
                conn.Execute("INSERT INTO products (code, name, price, quantity) VALUES (@code, @name, @price, @quantity)", product);
            }
        }

        public static void updateProduct(string code, ProductModel updatedProduct)
        {
            using (IDbConnection conn = new SqliteConnection(LoadConnectionString()))
            {
                conn.Execute(@"UPDATE products 
                       SET name = @name, 
                           price = @price, 
                           quantity = @quantity 
                       WHERE code = @code",
                    new
                    {
                        code = code,
                        name = updatedProduct.name,
                        price = updatedProduct.price,
                        quantity = updatedProduct.quantity
                    });
            }
        }

        public static void DeleteProductByCode(string code)
        {
            using (IDbConnection conn = new SqliteConnection(LoadConnectionString()))
            {
                conn.Execute("DELETE FROM products WHERE code = @code", new { code });
            }
        }

        public static List<TransactionModel> LoadTransactions()
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                string query = @"
            SELECT 
                t.id,
                t.items,
                t.total,                
                t.money,                
                t.changes,                
                t.user_id,
                t.timestamp,
                u.display_name AS user
            FROM transactions as t
            LEFT JOIN users as u ON t.user_id = u.Id
            ORDER BY t.Timestamp DESC
        ";

                return conn.Query<TransactionModel>(query).ToList();
            }
        }


        public static void SaveTransaction(TransactionModel transaction)
        {
            using (var conn = new SqliteConnection(connectionString))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"INSERT INTO transactions (items, total, money, changes, user_id, timestamp)
                            VALUES (@items, @total, @money, @changes, @userID, @timestamp)";

                cmd.Parameters.AddWithValue("@items", transaction.items);
                cmd.Parameters.AddWithValue("@total", transaction.total);
                cmd.Parameters.AddWithValue("@money", transaction.money);
                cmd.Parameters.AddWithValue("@changes", transaction.changes);
                cmd.Parameters.AddWithValue("@userID", transaction.user_id);
                cmd.Parameters.AddWithValue("@timestamp", transaction.timestamp);

                cmd.ExecuteNonQuery();
            }
        }



        private static string LoadConnectionString(string id = "Default")
        {
            return Program.AppConfig.GetConnectionString(id);
        }
    }
}
