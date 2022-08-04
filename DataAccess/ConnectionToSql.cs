using System;
using System.Data.SqlClient;
namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server = DESKTOP-GFG0RPB\\SQLEXPRESS;DataBase= ETRA;integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
