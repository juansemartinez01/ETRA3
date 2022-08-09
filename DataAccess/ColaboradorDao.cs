using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class ColaboradorDao:ConnectionToSql
    {
        public string[] BuscarColaborador(int legajo, string nombre, string apellido)
        {
            string[] colaboradorArray = new string[7];
            colaboradorArray[0] = "";
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    if(nombre != "" || apellido != "")
                    {
                        command.CommandText = "SELECT * FROM Colaborador WHERE nombre LIKE @nombre AND apellido LIKE @apellido AND borradoLogico = 0";
                        command.Parameters.AddWithValue("@nombre", '%' + nombre + '%');
                        command.Parameters.AddWithValue("@apellido", '%' + apellido + '%');
                    }
                    else
                    {
                        command.CommandText = "SELECT * FROM Colaborador WHERE legajo = @legajo AND borradoLogico = 0";
                        command.Parameters.AddWithValue("@legajo", legajo);
                    }
                    
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            return ReadSingleRow((IDataRecord)reader);
                        }
                        return colaboradorArray;
                        
                    }
                    else
                    {
                        return colaboradorArray;
                    }
                }
            }
        }
        public string BuscarLegajoUltimoColaborador()
        {
            
            
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "SELECT MAX(legajo) FROM Colaborador WHERE borradoLogico = 0";
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
        public string[] ReadSingleRow(IDataRecord dataRecord)
        {
            string[] atributosColaborador = new string[7];
            
            for (int i = 0; i < 7; i++)
            {
                atributosColaborador[i] = "" + dataRecord[i] + "";
            }


            return atributosColaborador;
        }
        public string AgregarDocumento(string Nombre, byte[] Documento, string Extension, int TipoMultimedia, int Legajo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO ColaboradorMultimedia VALUES (@nombre, @documento, @extension, @tipo, @legajoColaborador,0)";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@nombre", Nombre);
                    command.Parameters.AddWithValue("@documento", Documento);
                    command.Parameters.AddWithValue("@extension", Extension);
                    command.Parameters.AddWithValue("@tipo", TipoMultimedia);
                    command.Parameters.AddWithValue("@legajoColaborador", Legajo);
                    command.ExecuteNonQuery();
                    return "Documento agregado con exito";



                }
            }
        }
        public DataTable BuscarDocumento(int TipoMultimedia, int Legajo)
        {
            DataTable tabla = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM ColaboradorMultimedia WHERE id_tipoMultimedia = @idTipo AND legajoColaborador = @legajoColaborador AND borradoLogico = 0";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@idTipo", TipoMultimedia);
                    command.Parameters.AddWithValue("@legajoColaborador", Legajo);
                    SqlDataReader lector = command.ExecuteReader();
                    tabla.Load(lector);
                    return tabla;



                }
            }
        }
        public int CrearColaborador(string nombre,string apellido,int dni,int cuit,string calle,int numeroCalle)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio,borradoLogico) VALUES (@nombreCalle,@numeroCalle,0,0)";                                             
                    command.Parameters.AddWithValue("@nombreCalle", calle);
                    command.Parameters.AddWithValue("@numeroCalle", numeroCalle);
                    command.CommandType = CommandType.Text;
                    var direccionCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (direccionCreada == 1)
                    {
                        using (var command2 = new SqlCommand())
                        {
                            command2.Connection = connection;
                            command2.CommandText = "INSERT INTO Colaborador (nombre,apellido,idDireccion,fechaIngreso,borradoLogico) VALUES (@nombre,@apellido,(SELECT MAX(id_direccion) FROM Direccion),GETDATE(),0)";
                            command2.Parameters.AddWithValue("@nombre", nombre);
                            command2.Parameters.AddWithValue("@apellido", apellido);
                            command2.CommandType = CommandType.Text;
                            
                            var colaboradorCreado = command2.EndExecuteNonQuery(command2.BeginExecuteNonQuery());
                            if (colaboradorCreado == 1)
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
        public int EliminarColaborador(int legajo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {

                    command.Connection = connection;
                    command.CommandText = "UPDATE Colaborador SET borradoLogico = 1 WHERE legajo = @legajo";
                    command.Parameters.AddWithValue("@legajo", legajo);
                    command.CommandType = CommandType.Text;
                    var ColaboradorEliminado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (ColaboradorEliminado == 1)
                    {
                        using (var command1 = new SqlCommand())
                        {

                            command1.Connection = connection;
                            command1.CommandText = "UPDATE HistorialCargo SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                            command1.Parameters.AddWithValue("@legajo", legajo);
                            command1.CommandType = CommandType.Text;
                            var HistorialCargoEliminado = command1.EndExecuteNonQuery(command1.BeginExecuteNonQuery());
                            if (HistorialCargoEliminado != 0)
                            {
                                using (var command2 = new SqlCommand())
                                {

                                    command2.Connection = connection;
                                    command2.CommandText = "UPDATE HistorialEvento SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                    command2.Parameters.AddWithValue("@legajo", legajo);
                                    command2.CommandType = CommandType.Text;
                                    var HistorialEventoEliminado = command2.EndExecuteNonQuery(command2.BeginExecuteNonQuery());
                                    if (HistorialEventoEliminado != 0)
                                    {
                                        using (var command3 = new SqlCommand())
                                        {

                                            command3.Connection = connection;
                                            command3.CommandText = "UPDATE HistorialEstado SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                            command3.Parameters.AddWithValue("@legajo", legajo);
                                            command3.CommandType = CommandType.Text;
                                            var HistorialEstadoEliminado = command3.EndExecuteNonQuery(command3.BeginExecuteNonQuery());
                                            if (HistorialEstadoEliminado != 0)
                                            {
                                                using (var command4 = new SqlCommand())
                                                {

                                                    command4.Connection = connection;
                                                    command4.CommandText = "UPDATE HistorialSalario SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                                    command4.Parameters.AddWithValue("@legajo", legajo);
                                                    command4.CommandType = CommandType.Text;
                                                    var HistorialSalarioEliminado = command4.EndExecuteNonQuery(command4.BeginExecuteNonQuery());
                                                    if (HistorialSalarioEliminado != 0)
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
        public int EliminarColaboradorPermanentemente(int legajo)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    
                    command.Connection = connection;
                    command.CommandText = "UPDATE Colaborador SET borradoLogico = 1 WHERE legajo = @legajo";
                    command.Parameters.AddWithValue("@legajo", legajo);
                    command.CommandType = CommandType.Text;
                    var ColaboradorEliminado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (ColaboradorEliminado == 1)
                    {
                        using (var command1 = new SqlCommand())
                        {

                            command1.Connection = connection;
                            command1.CommandText = "UPDATE HistorialCargo SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                            command1.Parameters.AddWithValue("@legajo", legajo);
                            command1.CommandType = CommandType.Text;
                            var HistorialCargoEliminado = command1.EndExecuteNonQuery(command1.BeginExecuteNonQuery());
                            if (HistorialCargoEliminado == 1)
                            {
                                using (var command2 = new SqlCommand())
                                {

                                    command2.Connection = connection;
                                    command2.CommandText = "UPDATE HistorialEvento SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                    command2.Parameters.AddWithValue("@legajo", legajo);
                                    command2.CommandType = CommandType.Text;
                                    var HistorialEventoEliminado = command2.EndExecuteNonQuery(command2.BeginExecuteNonQuery());
                                    if (HistorialEventoEliminado == 1)
                                    {
                                        using (var command3 = new SqlCommand())
                                        {

                                            command3.Connection = connection;
                                            command3.CommandText = "UPDATE HistorialEstado SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                            command3.Parameters.AddWithValue("@legajo", legajo);
                                            command3.CommandType = CommandType.Text;
                                            var HistorialEstadoEliminado = command3.EndExecuteNonQuery(command3.BeginExecuteNonQuery());
                                            if (HistorialEstadoEliminado == 1)
                                            {
                                                using (var command4 = new SqlCommand())
                                                {

                                                    command4.Connection = connection;
                                                    command4.CommandText = "UPDATE HistorialSalario SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                                    command4.Parameters.AddWithValue("@legajo", legajo);
                                                    command4.CommandType = CommandType.Text;
                                                    var HistorialSalarioEliminado = command4.EndExecuteNonQuery(command4.BeginExecuteNonQuery());
                                                    if (HistorialSalarioEliminado == 1)
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

    }
}
