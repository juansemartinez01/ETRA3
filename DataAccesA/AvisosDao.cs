using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataAccesA
{
    public class AvisosDao : ConnectionToSql
    {
        /*Insercion del aviso*/
        public string insertarAviso(int idTipoAviso,string descripcion,DateTime fechaOcurrencia,DateTime fechaNotificacion)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Aviso VALUES (@idTipoAviso,@descripcion,GETDATE(),Format(@fechaOcurrencia, 'yyyy - MM - dd'),Format(@fechaNotificacion, 'yyyy - MM - dd'),0)";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idTipoAviso", idTipoAviso);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        
                        command.Parameters.AddWithValue("@fechaOcurrencia", fechaOcurrencia);
                        command.Parameters.AddWithValue("@fechaNotificacion", fechaNotificacion);

                        int insecionExitosa = command.ExecuteNonQuery();
                        if(insecionExitosa == 1)
                        {
                            return "Insercion del aviso exitosa";
                        }
                        else
                        {
                            return "Ocurrio un error al insertar el aviso";
                        }
                        



                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string declararNotificados(int idAviso, int[] legajosNotificados)
        {
            try
            {
                int cantidadNotificados = 0;
                foreach (int legajo in legajosNotificados)
                {
                    if (legajo != 0)
                    {
                        cantidadNotificados++;
                    }  
                }
                int insercionesExitosas = 0;
                using (var connection = GetConnection())
                {
                    connection.Open();
                    foreach (int legajo in legajosNotificados)
                    {
                        if(legajo == 0)
                        {
                            continue;
                        }
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "INSERT INTO AvisoXColaborador VALUES(@legajo,@idAviso,0)";
                            command.Parameters.AddWithValue("@legajo", legajo);
                            command.Parameters.AddWithValue("@idAviso", idAviso);
                            command.CommandType = CommandType.Text;
                            int insecionExitosa = command.ExecuteNonQuery();
                            insercionesExitosas += 1;
                            
                        }
                    }
                    if(insercionesExitosas == cantidadNotificados)
                    {
                        return "Insercion de los notificados exitosa";
                    }
                    else
                    {
                        return "Insercion de los notificados erronea";
                    }
                }


            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string buscarIdUltimoAviso()
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT MAX(id_aviso) FROM Aviso WHERE borradoLogico = 0";
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
    }
}
