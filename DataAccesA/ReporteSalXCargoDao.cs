using System.Data.SqlClient;
using System.Data;


namespace DataAccesA
{
    public class ReporteSalXCargoDao : ConnectionToSql
    {
        public DataTable getSalXCargo()
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = connection;
                    comando.CommandText = @"select c.nombre, sum(s.monto) from Salario s 
                                            join HistorialSalario hs on s.id_salario = hs.id_salario
                                            join HistorialCargo hc on hs.legajoColaborador = hc.legajoColaborador
                                            join Cargo c on hc.id_cargo = c.id_cargo
                                            group by c.nombre";
                    comando.CommandType = CommandType.Text;
                    SqlDataReader reader = comando.ExecuteReader();
                    resultado.Load(reader);
                    reader.Dispose();
                }
            }
            
            return resultado;

        }
    }
}
