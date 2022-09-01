using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class EventosDao:ConnectionToSql
    {

        public DataTable obtenerEventos(string legajo)
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TE.nombre as 'Nombre', E.descripcion as 'Descripción', CONVERT(varchar,HE.fechaInicio,103) AS 'Fecha de Inicio', CONVERT(varchar,HE.fechaFin,103) AS 'Fecha Fin', CONVERT(varchar,HE.fechaRegistro,103) AS 'Fecha de Registro' FROM HistorialEvento HE JOIN Colaborador C ON HE.legajoColaborador = C.legajo JOIN Evento E ON E.id_evento = HE.id_evento JOIN TipoEvento TE ON TE.id_tipoEvento = E.id_tipoEvento WHERE C.legajo = @legajo AND C.borradoLogico = 0";
                    command.Parameters.AddWithValue("@legajo", legajo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
        public DataTable getAllEventos()
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT C.legajo as 'Legajo Colaborador', TE.nombre as 'Nombre Evento', E.descripcion as 'Descripción', CONVERT(varchar,HE.fechaInicio,103) AS 'Fecha de Inicio', CONVERT(varchar,HE.fechaFin,103) AS 'Fecha Fin', CONVERT(varchar,HE.fechaRegistro,103) AS 'Fecha de Registro' FROM HistorialEvento HE JOIN Colaborador C ON HE.legajoColaborador = C.legajo JOIN Evento E ON E.id_evento = HE.id_evento JOIN TipoEvento TE ON TE.id_tipoEvento = E.id_tipoEvento WHERE C.borradoLogico = 0";
                    
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
        public string InsertarEvento(int idTipoEvento,int legajoColaborador, string descripcion,DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {


                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command2 = new SqlCommand())
                    {
                        command2.Connection = connection;
                        command2.CommandText = "INSERT INTO Evento VALUES (@descripcion,@idTipoEvento,0)";
                        command2.CommandType = CommandType.Text;
                        command2.Parameters.AddWithValue("@idTipoEvento", idTipoEvento);
                        command2.Parameters.AddWithValue("@descripcion", descripcion);

                        int resultado = command2.ExecuteNonQuery();
                        if (resultado == 1)
                        {


                            using (var command = new SqlCommand())
                            {
                                int idEvento = int.Parse(BuscarIdUltimoEvento());
                                command.Connection = connection;
                                command.CommandText = "INSERT INTO HistorialEvento VALUES (@idEvento,Format(@fechaInicio, 'yyyy - MM - dd'),Format(@fechaFin, 'yyyy - MM - dd'),GETDATE(),@legajoColaborador,0)";
                                command.CommandType = CommandType.Text;
                                command.Parameters.AddWithValue("@idEvento", idEvento);
                                command.Parameters.AddWithValue("@legajoColaborador", legajoColaborador);
                                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                                command.ExecuteNonQuery();
                                return "Evento creado con exito.";



                            }



    ;

                        }
                        else
                        {
                            return "Error al crear el evento";
                        }



                    }
                }
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string BuscarIdUltimoEvento()
        {
            try
            {



                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT MAX(id_evento) FROM Evento WHERE borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord idEvento = (IDataRecord)reader;
                                return "" + idEvento[0] + "";
                            }
                            return "Error con la base de datos";

                        }
                        else
                        {
                            return "Error con la base de datos";
                        }
                    }
                }
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
    }
}