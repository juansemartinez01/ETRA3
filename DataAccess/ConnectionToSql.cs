using System;
using System.Data.SqlClient;
namespace DataAccess
{
    public abstract class ConnectionToSql
    {
        private readonly string connectionString;

        public ConnectionToSql()
        {
            connectionString = "Server = DESKTOP-LDGCSE9\\SQLEXPRESS;DataBase= ETRA;integrated security= true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
