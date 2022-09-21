using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesA
{
    public class CuentaColaboradorDao:ConnectionToSql
    {

        public DataTable BuscarCuentaColaborador(int legajo, string nombre, string apellido)
        {
            DataTable cuentaColaborador = new DataTable();
            //colaboradorArray[0] = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT numeroCuenta as 'Numero de cuenta',saldoAdeudado as 'Saldo adeudado',legajoColaborador as 'Legajo colaborador' FROM CuentaColaborador WHERE legajoColaborador = @legajo AND borradoLogico = 0";
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        cuentaColaborador.Load(reader);
                        return cuentaColaborador;
                    }
                }
            }
            catch (Exception ex)
            {
                return cuentaColaborador;
            }
        }
        public string BuscarIdUltimaCuenta()
        {

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT MAX(numeroCuenta) FROM CuentaColaborador WHERE borradoLogico = 0";
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

        public string crearCuentaColaborador(int legajo, float monto)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO CuentaColaborador VALUES (@monto,0)";
                        command.Parameters.AddWithValue("@monto", monto);
                        command.CommandType = CommandType.Text;
                        var cuentaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if(cuentaCreada == 1)
                        {
                            using (var command1 = new SqlCommand())
                            {
                                command1.Connection = connection;
                                command1.CommandText = "INSERT INTO HistorialCuentaColaborador VALUES (GETDATE(),NULL,@legajo,@nroCuenta,0)";
                                command1.Parameters.AddWithValue("@legajo", legajo);
                                command1.Parameters.AddWithValue("@nroCuenta", int.Parse(BuscarIdUltimaCuenta()));
                                command1.CommandType = CommandType.Text;
                                var historialCreado = command1.EndExecuteNonQuery(command1.BeginExecuteNonQuery());
                                if (historialCreado == 1)
                                {
                                    return "Cuenta creada con exito.";

                                }
                                else
                                {
                                    return "Error al crear la cuenta.";
                                }
                            }

                        }
                        else
                        {
                            return "Error al crear la cuenta.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string modificarSaldo(int legajo,float monto)
        {
            int idHistorialCuentaActual = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT idHistorialCuenta FROM HistorialCuentaColaborador WHERE legajoColaborador = @legajo AND fechaFin IS NULL AND borradoLogico = 0";
                        command.Parameters.AddWithValue("@lagajo", legajo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord rowHistorialCuenta = (IDataRecord)reader;
                                idHistorialCuentaActual = int.Parse(rowHistorialCuenta[0].ToString());
                            }
                            
                                using (var command1 = new SqlCommand())
                                {
                                command1.Connection = connection;
                                command1.CommandText = "UPDATE HistorialCuentaColaborador SET fechaFin = GETDATE() WHERE legajoColaborador = @legajo AND fechaFin IS NULL AND borradoLogico = 0";
                                command1.Parameters.AddWithValue("@legajo", legajo);
                                command1.CommandType = CommandType.Text;
                                    var exito = command1.EndExecuteNonQuery(command1.BeginExecuteNonQuery());
                                if(exito == 1)
                                {
                                    return crearCuentaColaborador(legajo, monto);
                                }
                                else
                                {
                                    return "Error para modificar el saldo.";
                                }
                                }
                            
                            return crearCuentaColaborador(legajo, monto);

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


    }
}
