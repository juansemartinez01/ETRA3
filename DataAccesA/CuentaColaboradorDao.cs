using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataAccesA
{
    public class CuentaColaboradorDao:ConnectionToSql
    {

        public DataTable BuscarCuentaColaborador(int legajo)
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
                        command.CommandText = "SELECT H.idHistorialCuenta AS 'Numero mov.',T.nombre AS 'Tipo movimiento',H.fechaInicio AS 'Fecha registro',H.montoMoviento AS 'Monto del mov.' FROM TipoMovimiento T JOIN MovimientosCuentaColaborador H ON T.id_tipoMovimiento = H.tipoMovimiento JOIN CuentaColaborador C ON C.numeroCuenta = H.nroCuenta WHERE H.legajoColaborador = @legajo AND H.borradoLogico = 0";
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
        public string buscarFondoMaximoPermitido(int legajo)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT C.SaldoMaximo FROM TipoMovimiento T JOIN MovimientosCuentaColaborador H ON T.id_tipoMovimiento = H.tipoMovimiento JOIN CuentaColaborador C ON C.numeroCuenta = H.nroCuenta WHERE H.legajoColaborador = @legajo AND H.borradoLogico = 0";
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord saldoMaximo = (IDataRecord)reader;
                                return "" + saldoMaximo[0] + "";
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
            catch(Exception ex)
            {
                return ex.Message;
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

        public string crearCuentaColaborador(int legajo, double monto)
        {
            monto = -monto;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO CuentaColaborador VALUES (0,0,@montoMaximo)";
                        command.Parameters.AddWithValue("@montoMaximo", monto);
                        command.CommandType = CommandType.Text;
                        var cuentaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if(cuentaCreada == 1)
                        {
                            using (var command1 = new SqlCommand())
                            {
                                command1.Connection = connection;
                                command1.CommandText = "INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),GETDATE(),@legajo,@nroCuenta,0,3,0)";
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
        public float buscarSaldo(int legajo)
        {
            float saldo = 123456789;


            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT DISTINCT saldoAdeudado FROM CuentaColaborador C JOIN MovimientosCuentaColaborador M ON M.nroCuenta = C.numeroCuenta WHERE M.idHistorialCuenta = (SELECT MAX(idHistorialCuenta) FROM MovimientosCuentaColaborador WHERE legajoColaborador = @legajo)";
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord saldoBase = (IDataRecord)reader;
                                saldo = float.Parse("" + saldoBase[0] + "");
                            }
                            return saldo;

                        }
                        else
                        {
                            return saldo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return saldo;
            }


            return saldo;
        }
        public string modificarSaldo(int legajo,float montoMovimiento,int tipoMovimiento)
        {
            if(tipoMovimiento == 2)
            {
                montoMovimiento = -montoMovimiento;
            }
            string montoActual = "";
            string montoMaximo;
            float montoNuevo;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();




                    using (var command1 = new SqlCommand())
                    {
                        command1.Connection = connection;
                        command1.CommandText = "SELECT C.saldoAdeudado,C.SaldoMaximo FROM CuentaColaborador C JOIN MovimientosCuentaColaborador M ON C.numeroCuenta = M.nroCuenta WHERE M.legajoColaborador = @legajo";
                        command1.Parameters.AddWithValue("@legajo", legajo);
                        command1.CommandType = CommandType.Text;
                        SqlDataReader reader = command1.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord montoActualBase = (IDataRecord)reader;
                                montoActual = "" + montoActualBase[0] + "";
                                montoMaximo = "" + montoActualBase[1] + "";
                                
                            }
                            reader.Close();
                            if (montoActual != "")
                            {
                                montoNuevo = float.Parse(montoActual) + montoMovimiento;



                                using (var command2 = new SqlCommand())
                                {
                                    command2.Connection = connection;
                                    command2.CommandText = "UPDATE CuentaColaborador SET saldoAdeudado = @montoNuevo WHERE numeroCuenta = (SELECT DISTINCT C.numeroCuenta FROM CuentaColaborador C JOIN MovimientosCuentaColaborador M ON M.nroCuenta = C.numeroCuenta WHERE M.legajoColaborador = @legajo)";
                                    command2.Parameters.AddWithValue("@legajo", legajo);
                                    command2.Parameters.AddWithValue("@montoNuevo", montoNuevo);
                                    command2.CommandType = CommandType.Text;
                                    var historialCreado = command2.EndExecuteNonQuery(command2.BeginExecuteNonQuery());
                                    if (historialCreado == 1)
                                    {
                                        int numeroCuenta = buscarNumeroCuenta(legajo);
                                        if (numeroCuenta == 0)
                                        {
                                            return "Error al buscar el numero de cuenta";
                                        }
                                        using (var command3 = new SqlCommand())
                                        {
                                            command3.Connection = connection;
                                            command3.CommandText = "INSERT INTO MovimientosCuentaColaborador VALUES (GETDATE(),NULL,@legajo,@numeroCuenta,0,@tipoMovimiento,@montoMovimiento)";
                                            command3.Parameters.AddWithValue("@legajo", legajo);
                                            command3.Parameters.AddWithValue("@numeroCuenta", numeroCuenta);
                                            command3.Parameters.AddWithValue("@tipoMovimiento", tipoMovimiento);
                                            command3.Parameters.AddWithValue("@montoMovimiento", montoMovimiento);
                                            command3.CommandType = CommandType.Text;
                                            var movimientoCreado = command3.EndExecuteNonQuery(command3.BeginExecuteNonQuery());
                                            if (movimientoCreado == 1)
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
                            
                            else
                            {
                                return "Error al realizar el movimiento";
                            }


                            

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
        public float buscarSaldoMovimiento(int idMovimiento)
        {
            float montoMovimiento = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT montoMoviento FROM MovimientosCuentaColaborador WHERE idHistorialCuenta = @idMovimiento";
                        command.Parameters.AddWithValue("@idMovimiento", idMovimiento);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord saldoBase = (IDataRecord)reader;
                                montoMovimiento = float.Parse("" + saldoBase[0] + "");
                            }
                            return montoMovimiento;

                        }
                        else
                        {
                            return montoMovimiento;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return montoMovimiento;
            }
        }
        public int buscarNumeroCuenta(int legajo)
        {
            int numeroCuenta = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT C.numeroCuenta FROM CuentaColaborador C JOIN MovimientosCuentaColaborador M ON M.nroCuenta = C.numeroCuenta WHERE M.legajoColaborador = @legajo";
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord numeroCuentaBase = (IDataRecord)reader;
                                numeroCuenta = int.Parse("" + numeroCuentaBase[0] + "");
                                return numeroCuenta;
                            }
                            return 0;

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
        public int eliminarMovimiento(int legajo,int idMovimiento) 
        {
            float saldoBaseDatos = buscarSaldo(legajo);
            float montoMovimiento = buscarSaldoMovimiento(idMovimiento);
            
            montoMovimiento = -montoMovimiento;

            float nuevoSaldo = saldoBaseDatos + montoMovimiento;

            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE CuentaColaborador SET saldoAdeudado = @montoNuevo WHERE numeroCuenta = (SELECT DISTINCT C.numeroCuenta FROM CuentaColaborador C JOIN MovimientosCuentaColaborador M ON M.nroCuenta = C.numeroCuenta WHERE M.legajoColaborador = @legajo)";
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.Parameters.AddWithValue("@montoNuevo", nuevoSaldo);
                        command.CommandType = CommandType.Text;
                        var cuentaCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if (cuentaCreada == 1)
                        {
                            using (var command1 = new SqlCommand())
                            {
                                command1.Connection = connection;
                                command1.CommandText = "DELETE FROM MovimientosCuentaColaborador WHERE idHistorialCuenta = @idMovimiento";
                                command1.Parameters.AddWithValue("@idMovimiento", idMovimiento);
                                
                                command1.CommandType = CommandType.Text;
                                var historialCreado = command1.EndExecuteNonQuery(command1.BeginExecuteNonQuery());
                                if (historialCreado == 1)
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
            }
            catch (Exception ex)
            {
                return 0;
            }



        }


    }
}
