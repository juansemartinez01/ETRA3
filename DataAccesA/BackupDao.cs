using System.Data.SqlClient;
using System.Data;
using System.IO;

namespace DataAccesA
{
    public class BackupDao : ConnectionToSql
    {
        public string GenerarBackup()
        {
            DirectoryInfo direc = Directory.GetParent(Directory.GetCurrentDirectory());
            DirectoryInfo direc1 = Directory.GetParent(direc.ToString());
            DirectoryInfo direc2 = Directory.GetParent(direc1.ToString());
            DirectoryInfo direc3 = Directory.GetParent(direc2.ToString());
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = "BACKUP DATABASE ETRA TO  DISK = @ubicacion";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@ubicacion", direc3.ToString() + "\\ETRA.bak");

                    command.ExecuteNonQuery();
                    return "Backup realizado con exito";



                }
            }
        }
    }
}
