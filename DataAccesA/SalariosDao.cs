using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessA
{
    public class SalariosDao : ConnectionToSql
    {
        public int modificarSalarioColaborador(int legajo, float monto)
        {
            try
            {


                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Salario VALUES (@monto,0)";
                        command.Parameters.AddWithValue("@monto", monto);
                        command.CommandType = CommandType.Text;
                        int salarioCreado = command.ExecuteNonQuery();
                        if (salarioCreado == 1)
                        {
                            using (var command1 = new SqlCommand())
                            {
                                command1.Connection = connection;
                                command1.CommandText = "UPDATE HistorialSalario SET fechaFin = GETDATE() WHERE legajoColaborador = @legajo AND fechaFin IS NULL";
                                command1.Parameters.AddWithValue("@legajo", legajo);
                                command1.CommandType = CommandType.Text;
                                int historialSalarioActualizado = command1.ExecuteNonQuery();
                                if (historialSalarioActualizado == 1)
                                {
                                    using (var command2 = new SqlCommand())
                                    {
                                        int idUltimoSalario = int.Parse(BuscarIdUltimoSalario());
                                        command2.Connection = connection;
                                        command2.CommandText = "INSERT INTO HistorialSalario VALUES(GETDATE(),NULL,@id_salario,@legajo,0)";
                                        command2.Parameters.AddWithValue("@legajo", legajo);
                                        command2.Parameters.AddWithValue("@id_salario", idUltimoSalario);
                                        command2.CommandType = CommandType.Text;
                                        int historialSalarioCreado = command2.ExecuteNonQuery();
                                        if (historialSalarioCreado == 1)
                                        {
                                            return 1;
                                        }
                                        else
                                        {
                                            return 0;
                                        }
                                    }
                                }
                                else
                                {
                                    return 0;
                                }
                            }
                        }
                        else
                        {
                            return 0;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public string BuscarIdUltimoSalario()
        {
            try
            {



                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT MAX(id_salario) FROM Salario WHERE borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord legajo = (IDataRecord)reader;
                                return "" + legajo[0] + "";
                            }
                            return "Error con la base de datos";

                        }
                        else
                        {
                            return "Error con la base de datos";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string[] ReadSingleRow(IDataRecord dataRecord)
        {
            string[] atributosColaborador = new string[7];

            for (int i = 0; i < 7; i++)
            {
                atributosColaborador[i] = "" + dataRecord[i] + "";
            }


            return atributosColaborador;
        }
    }
}
