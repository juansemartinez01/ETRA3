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
                    command.CommandText = "select h.legajoColaborador,e.descripcion, CONVERT(varchar,h.fechaInicio,103) as fechaInicio,CONVERT(varchar,h.fechaFin,103) as fechaFin, CONVERT(varchar,h.fechaRegistro,103) as fechaRegistro, t.nombre from HistorialEvento h join Evento e on e.id_evento = h.id_evento join TipoEvento t on t.id_tipoEvento = e.id_tipoEvento where h.legajoColaborador = @legajo";
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
