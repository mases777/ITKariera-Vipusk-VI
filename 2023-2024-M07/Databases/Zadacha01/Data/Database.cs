using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Zadacha01.Data
{
    public static class Database
    {
        private static string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;Database=shop6;Integrated Security=True";
        
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
