using System.Data.SqlClient;
namespace DataAccesA
{
        public abstract class ConnectionToSql
        {
            private readonly string connectionString;

            public ConnectionToSql()
            {
                //connectionString = "Server = (local)\\SQLEXPRESS;DataBase= ETRA;integrated security= true";
                connectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = ETRA; Integrated Security = True"; 
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
}
