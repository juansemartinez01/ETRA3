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
                    command.CommandText = "SELECT TE.nombre AS Nombre, E.descripcion AS Descripcion, CONVERT(varchar,HE.fechaInicio,103) AS 'Fecha de Inicio', CONVERT(varchar,HE.fechaFin,103) AS 'Fecha Fin', CONVERT(varchar,HE.fechaRegistro,103) AS 'Fecha de registro' FROM HistorialEvento HE JOIN Colaborador C ON HE.legajoColaborador = C.legajo JOIN Evento E ON E.id_evento = HE.id_evento JOIN TipoEvento TE ON TE.id_tipoEvento = E.id_tipoEvento WHERE C.legajo = @legajo AND C.borradoLogico = 0";
                    command.Parameters.AddWithValue("@legajo", legajo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
    }
}