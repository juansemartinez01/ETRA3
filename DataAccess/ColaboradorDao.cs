using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ColaboradorDao:ConnectionToSql
    {
        public string BuscarColaborador(string nombre)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM Colaborador WHERE nombre = @nombre";
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return ReadSingleRow((IDataRecord)reader);
                        }
                        return "";
                        
                    }
                    else
                    {
                        return "No hay coincidencias.";
                    }
                }
            }
        }
        public string ReadSingleRow(IDataRecord dataRecord)
        {
             return "Mail:" + dataRecord[3] + ".";
        }
    }
}
