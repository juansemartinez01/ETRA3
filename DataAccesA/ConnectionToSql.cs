using System.Data.SqlClient;
namespace DataAccesA
{
        public abstract class ConnectionToSql
        {
            private readonly string connectionString;

            public ConnectionToSql()
            {
                connectionString = "Server=tcp:DBServer\\ServidorEtra,49500;DataBase=ETRA;User ID=acceso;Password=admin123";
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
}
