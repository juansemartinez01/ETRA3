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
        public DataTable cumpleañosFamiliaresColaboradores()
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
                        command.CommandText = "SELECT FC.nombreFamiliar AS 'Nombre',TF.nombre AS 'Relacion', C.nombre AS 'Nombre colaborador',C.apellido AS 'Apellido Colaborador', DAY(FC.fechaNacimiento) AS 'Dia de cumpleaños' FROM FamiliarColaborador FC JOIN Colaborador C ON FC.legajoColaborador = C.legajo JOIN TipoFamiliar TF ON TF.idTipoFamiliar = FC.tipoFamiliar WHERE MONTH(FC.fechaNacimiento) = MONTH(GETDATE()) AND FC.fechaNacimiento IS NOT NULL";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        cumpleañosDelMes.Load(reader);
                        return cumpleañosDelMes;
                    }
                }


            }
            catch (Exception ex)
            {

                return cumpleañosDelMes;
            }
        }
    }
}
