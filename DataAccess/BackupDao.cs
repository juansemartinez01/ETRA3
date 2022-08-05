using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class BackupDao:ConnectionToSql
    {
        public string GenerarBackup()
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = "BACKUP DATABASE ETRA TO  DISK = @ubicacion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ubicacion", "C:\\Users\\juans\\Desktop\\ETRA2\\ETRA.bak");
                    
                    command.ExecuteNonQuery();
                    return "Backup realizado con exito";



                }
            }
        }
    }
}
