using System;
using System.Data.SqlClient;
using System.Data;

namespace DataAccesA
{
    public class FamiliarColaboradorDao:ConnectionToSql
    {
        public string crearFamiliarColaborador(int tipoFamiliar,int legajoColaborador,string nombreFamiliar,string apellidoFamiliar, DateTime fechaNacimiento)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO FamiliarColaborador VALUES (@tipoFamiliar,@legajo,@nombreFamiliar,@apellidoFamiliar,@fechaNacimiento,0)";
                        command.Parameters.AddWithValue("@tipoFamiliar", tipoFamiliar);
                        command.Parameters.AddWithValue("@legajo", legajoColaborador);
                        command.Parameters.AddWithValue("@nombreFamiliar", nombreFamiliar);
                        command.Parameters.AddWithValue("@apellidoFamiliar", apellidoFamiliar);
                        command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                        command.CommandType = CommandType.Text;
                        var familiarRegistrado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if (familiarRegistrado == 1)
                        {
                            return "Familiar registrado con exito.";

                        }
                        else
                        {
                            return "Error al registrar el familiar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string eliminarFamiliarColaborador(int legajoColaborador,int idFamiliar)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE FamiliarColaborador SET borradoLogico = 1 WHERE legajo = @legajoColaborador AND idFamiliar = @idFamiliar";
                        command.Parameters.AddWithValue("@idFamiliar", idFamiliar);
                        command.Parameters.AddWithValue("@legajo", legajoColaborador);
                        
                        command.CommandType = CommandType.Text;
                        var familiarRegistrado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if (familiarRegistrado == 1)
                        {
                            return "Familiar eliminado con exito.";

                        }
                        else
                        {
                            return "Error al eliminar el familiar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string modificarFamiliarColaborador(int tipoFamiliar,string nombreFamiliar,string apellidoFamiliar,DateTime fechaNacimiento,int legajoColaborador,int idFamiliar)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE FamiliarColaborador SET tipoFamiliar = @tipoFamiliar,nombreFamiliar = @nombreFamiliar,apellidoFamiliar = @apellidoFamiliar,fechaNacimiento = @fechaNacimiento WHERE legajo = @legajoColaborador AND idFamiliar = @idFamiliar";
                        command.Parameters.AddWithValue("@idFamiliar", idFamiliar);
                        command.Parameters.AddWithValue("@legajo", legajoColaborador);

                        command.CommandType = CommandType.Text;
                        var familiarRegistrado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if (familiarRegistrado == 1)
                        {
                            return "Familiar eliminado con exito.";

                        }
                        else
                        {
                            return "Error al eliminar el familiar.";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public DataTable getCumpleañosMesActual()
        {
            DataTable dt = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select legajoColaborador, fechaNacimiento, nombreFamiliar from FamiliarColaborador where MONTH(GETDATE()) = MONTH(fechaNacimiento)  AND borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        dt.Load(command.ExecuteReader());
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                return dt;
            }
        }
    }
}
