﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesA
{
    public class EventosDao : ConnectionToSql
    {

        public DataTable obtenerEventos(string legajo,bool soloPagosSueldo)
        {
            string parametros = "";
            if (soloPagosSueldo) {
                parametros += " AND TE.id_tipoEvento = 5";
            }
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT TE.nombre as 'Tipo', E.descripcion as 'Descripción', CONVERT(varchar,HE.fechaInicio,103) AS 'Fecha de Inicio', CONVERT(varchar,HE.fechaFin,103) AS 'Fecha Fin', CONVERT(varchar,HE.fechaRegistro,103) AS 'Fecha de Registro',E.id_evento AS 'Numero' FROM HistorialEvento HE JOIN Colaborador C ON HE.legajoColaborador = C.legajo JOIN Evento E ON E.id_evento = HE.id_evento JOIN TipoEvento TE ON TE.id_tipoEvento = E.id_tipoEvento WHERE C.legajo = @legajo AND C.borradoLogico = 0 AND E.borradoLogico = 0 AND HE.borradoLogico = 0" + parametros;
                    command.Parameters.AddWithValue("@legajo", legajo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
        public DataTable getAllEventos()
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT C.legajo as 'Legajo Colaborador', TE.nombre as 'Tipo', E.descripcion as 'Descripción', CONVERT(varchar,HE.fechaInicio,103) AS 'Fecha de Inicio', CONVERT(varchar,HE.fechaFin,103) AS 'Fecha Fin', CONVERT(varchar,HE.fechaRegistro,103) AS 'Fecha de Registro' FROM HistorialEvento HE JOIN Colaborador C ON HE.legajoColaborador = C.legajo JOIN Evento E ON E.id_evento = HE.id_evento JOIN TipoEvento TE ON TE.id_tipoEvento = E.id_tipoEvento WHERE C.borradoLogico = 0 AND E.borradoLogico = 0 AND HE.borradoLogico = 0";

                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
        public string InsertarEvento(int idTipoEvento, int legajoColaborador, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {


                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command2 = new SqlCommand())
                    {
                        command2.Connection = connection;
                        command2.CommandText = "INSERT INTO Evento VALUES (@descripcion,@idBusqueda,0)";
                        command2.CommandType = CommandType.Text;
                        command2.Parameters.AddWithValue("@idBusqueda", idTipoEvento);
                        command2.Parameters.AddWithValue("@descripcion", descripcion);

                        int resultado = command2.ExecuteNonQuery();
                        if (resultado == 1)
                        {


                            using (var command = new SqlCommand())
                            {
                                int idEvento = int.Parse(BuscarIdUltimoEvento());
                                command.Connection = connection;
                                command.CommandText = "INSERT INTO HistorialEvento VALUES (@idEvento,Format(@fechaInicio, 'yyyy - MM - dd'),Format(@fechaFin, 'yyyy - MM - dd'),GETDATE(),@legajoColaborador,0)";
                                command.CommandType = CommandType.Text;
                                command.Parameters.AddWithValue("@idEvento", idEvento);
                                command.Parameters.AddWithValue("@legajoColaborador", legajoColaborador);
                                command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                                command.Parameters.AddWithValue("@fechaFin", fechaFin);
                                command.ExecuteNonQuery();
                                return "Evento creado con exito.";



                            }



    ;

                        }
                        else
                        {
                            return "Error al crear el evento";
                        }



                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string BuscarIdUltimoEvento()
        {
            try
            {



                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT MAX(id_evento) FROM Evento WHERE borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord idEvento = (IDataRecord)reader;
                                return "" + idEvento[0] + "";
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
        public string eliminarEvento(int idEvento)
        {
            DataTable documentosAsociados = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        
                        command.Connection = connection;
                        command.CommandText = "UPDATE Evento SET borradoLogico = 1 WHERE id_evento = @idEvento";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        int eventoEliminado = command.ExecuteNonQuery();
                        if(eventoEliminado != 1)
                        {
                            return "Ocurrio un error al eliminar el evento.";
                        }
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "UPDATE HistorialEvento SET borradoLogico = 1 WHERE id_evento = @idEvento";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        int historialEventoEliminado = command.ExecuteNonQuery();
                        if (historialEventoEliminado != 1)
                        {
                            return "Ocurrio un error al eliminar el historial del evento.";
                        }
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT id_colaboradorMultimedia FROM ColaboradorMultimedia  WHERE id_evento = @idEvento";
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        documentosAsociados.Load(reader);
                        
                    }
                    int cantidadDocumentos = documentosAsociados.Rows.Count;
                    if (cantidadDocumentos > 0)
                    {



                        using (var command = new SqlCommand())
                        {

                            command.Connection = connection;
                            command.CommandText = "UPDATE ColaboradorMultimedia SET borradoLogico = 1 WHERE id_evento = @idEvento";
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@idEvento", idEvento);
                            int documentosEventoEliminado = command.ExecuteNonQuery();
                            if (documentosEventoEliminado != cantidadDocumentos)
                            {
                                return "Ocurrio un error al eliminar los documentos del evento.";
                            }
                        }
                    }
                    return "Evento eliminado con exito.";



                }
            }catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string modificarEvento(int idEvento, int tipoEvento, DateTime fechaInicio, DateTime fechaFin, DateTime fechaRegistro, string descripcion)
        {
            
            try
            {

                using (var connection = GetConnection())
                {
                    connection.Open();
                 
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "UPDATE HistorialEvento SET fechaInicio = Format(@fechaInicio, 'yyyy - MM - dd'),fechaFin = Format(@fechaFin, 'yyyy - MM - dd'),fechaRegistro = Format(@fechaRegistro, 'yyyy - MM - dd') WHERE id_evento = @idEvento";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        command.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                        command.Parameters.AddWithValue("@fechaFin", fechaFin);
                        command.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                        int historialEventoModificado = command.ExecuteNonQuery();
                        if (historialEventoModificado != 1)
                        {
                            return "Ocurrio un error al modificar el historial del evento.";
                        }
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "UPDATE Evento SET id_tipoEvento = @tipoEvento,descripcion = @descripcion WHERE id_evento = @idEvento";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        command.Parameters.AddWithValue("@tipoEvento", tipoEvento);
                        command.Parameters.AddWithValue("@descripcion", descripcion);

                        int eventoModificado = command.ExecuteNonQuery();
                        if (eventoModificado != 1)
                        {
                            return "Ocurrio un error al modificar el evento.";
                        }
                    }
                    return "Evento modificado con exito";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public int buscarIdConNombre(string nombreBusqueda,string tablaBusqueda)
        {
            string columnaBusqueda = "";
            string columnaWhere = "";
            if (tablaBusqueda == "TipoEvento")
            {
                columnaBusqueda = "id_tipoEvento";
                columnaWhere = "nombre";
            }
            if(tablaBusqueda == "EstadoColaborador")
            {
                columnaBusqueda = "id_estado";
                columnaWhere = "nombre";
            }
            if (tablaBusqueda == "Cargo")
            {
                columnaBusqueda = "id_cargo";
                columnaWhere = "nombre";
            }
            if (columnaBusqueda == "" || columnaWhere == "")
            {
                return 0;
            }
            int idBusqueda = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "SELECT "+ columnaBusqueda +" FROM "+ tablaBusqueda + " WHERE "+ columnaWhere + " LIKE @nombreBusqueda AND borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@nombreBusqueda", nombreBusqueda);
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord idReader = (IDataRecord)reader;
                                idBusqueda = int.Parse("" + idReader[0] + "");
                            }
                            reader.Close();
                            return idBusqueda;

                        }
                        else
                        {
                            return idBusqueda;
                        }
                    }
                    

                }


                }catch(Exception ex)
            {
                return idBusqueda;
            }
        }
    }
    


}
