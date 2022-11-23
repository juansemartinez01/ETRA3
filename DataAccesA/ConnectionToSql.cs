using System.Data.SqlClient;
namespace DataAccesA
{
        public abstract class ConnectionToSql
        {
            private readonly string connectionString;

            public ConnectionToSql()
            {
                connectionString = "Data Source=192.168.0.89;Initial Catalog=ETRA;Persist Security Info=True;User ID=soporte;Password=soporte";
            }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
}
