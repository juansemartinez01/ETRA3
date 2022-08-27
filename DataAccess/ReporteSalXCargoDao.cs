using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ReporteSalXCargoDao : ConnectionToSql
    {
        public DataTable getSalXCargo()
        {
            DataTable resultado = new DataTable();
            using (var connection = new SqlConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = @"select sum(s.monto), c.nombre from Salario s 
                                            join HistorialSalario hs on s.id_salario = hs.id_salario
                                            join HistorialCargo hc on hs.legajoColaborador = hc.legajoColaborador
                                            join Cargo c on hc.id_cargo = c.id_cargo
                                            group by c.nombre";
                    comando.CommandType = CommandType.Text;
                    var reader = comando.ExecuteReader();
                    resultado.Load(reader);
                    reader.Dispose();
                }
            }

            return resultado;
            
        }
    }
}
