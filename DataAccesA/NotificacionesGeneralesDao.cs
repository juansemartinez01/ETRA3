using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataAccesA
{
    public class NotificacionesGeneralesDao:ConnectionToSql
    {

        public DataTable notificacionesDeCumpleañosColaboradores()
        {
            DataTable cumpleañosDelMes = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT nombre AS 'Nombre',apellido AS 'Apellido',DAY(fechaNacimiento) AS 'Cumpleaños'  FROM Colaborador WHERE MONTH(fechaNacimiento) = MONTH(GETDATE())"; 
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        cumpleañosDelMes.Load(reader);
                        return cumpleañosDelMes;
                    }
                }


                }catch(Exception ex)
            {
                
                return cumpleañosDelMes;
            }
        }
    }
}
