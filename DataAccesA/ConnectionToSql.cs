using System.Data.SqlClient;
namespace DataAccesA
{
        public abstract class ConnectionToSql
        {
            private readonly string connectionString;

            public ConnectionToSql()
            {
            //connectionString = @"Server = tcp:DBServer\ServidorEtra,49500;DataBase= ETRA;Integrated Security = True";
            //connectionString = @"Server = tcp:SERVERETRA\Etra3,49500;DataBase= ETRA;User Id = AppAccess; Password = 7dGUwNjnZL5qyiV";
            connectionString = "Data Source = localhost\\SQLEXPRESS; Initial Catalog = ETRA; Integrated Security = True";
        }
            protected SqlConnection GetConnection()
            {
                return new SqlConnection(connectionString);
            }
        }
}
