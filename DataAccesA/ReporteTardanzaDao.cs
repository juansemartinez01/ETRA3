using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DataAccesA
{
    public class ReporteTardanzaDao:ConnectionToSql
    {
        public DataTable getTardanzas(DateTime fechaInicio, DateTime fechaFin)
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    
                    command.CommandText = @"SELECT H.legajoColaborador AS 'Legajo Colaborador',ca.nombre as 'Cargo', E.descripcion as 'Descripcion', convert(varchar,H.fechaInicio,108) as 'HoraLlegada', convert(varchar,H.fechaInicio,3) as 'Fecha'
                                            FROM HistorialEvento H JOIN Evento E ON H.id_evento = E.id_evento 
                                            JOIN TipoEvento T ON T.id_tipoEvento = E.id_tipoEvento 
                                            JOIN HistorialCargo hc on H.legajoColaborador = hc.legajoColaborador 
                                            JOIN Cargo ca on hc.id_cargo = ca.id_cargo 
                                            WHERE E.id_tipoEvento = 2 and H.fechaInicio >= @fechaInicio and H.fechaFin <= @fechaFin";
                    command.CommandType = CommandType.Text;
                    command.Parameters.Add("@fechaInicio", SqlDbType.Date).Value = fechaInicio;
                    command.Parameters.Add("@fechaFin", SqlDbType.Date).Value = fechaFin;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    reader.Dispose();
                }
            }
            return resultado;

        }
    }
}
