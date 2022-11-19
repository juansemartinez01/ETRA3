using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace DataAccesA
{   
    public class AvisosDao : ConnectionToSql
    {
        
        /*Insercion del aviso*/
        public string insertarAviso(int idTipoAviso, string descripcion, DateTime fechaOcurrencia, DateTime fechaNotificacion)
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
                        if (insecionExitosa == 1)
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
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string declararNotificados(int idAviso, int[] legajosNotificados)
        {
            
            DataTable dt = new DataTable();
            /*Aca buscamos lso legajos de todos los caolaboradores para confirmar que los legajos que ingresan existan*/
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT legajo FROM Colaborador WHERE borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        dt.Load(reader);
                        
                    }
                }
            bool legajoEncontrado = false;
            for (int i = 0; i < legajosNotificados.Length; i++)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (int.Parse(row["Legajo"].ToString()) == legajosNotificados[i])
                    {
                        legajoEncontrado = true;
                        break;
                    }
                }
                if (!legajoEncontrado)
                {
                    legajosNotificados[i] = 0;
                }
                legajoEncontrado = false;
            }
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
                        if (legajo == 0)
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
                    if (insercionesExitosas == cantidadNotificados)
                    {
                        return "Insercion de los notificados exitosa";
                    }
                    else
                    {
                        return "Insercion de los notificados erronea";
                    }
                }


            }
            catch (Exception ex)
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

        public bool actualizarAviso(int id_aviso, DateTime fechaNotificacion)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Aviso set fechaNotificacion = Format(@fechaNotificacion, 'yyyy - MM - dd') WHERE id_aviso = @id_aviso";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id_aviso", id_aviso);
                        command.Parameters.AddWithValue("@fechaNotificacion", fechaNotificacion);
                        int insecionExitosa = command.ExecuteNonQuery();
                        if (insecionExitosa == 1)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        
        public DataTable getAllAvisosMesActual()
        {
            DataTable resultado = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT ta.nombre, c.legajo,  a.fechaOcurrencia, a.descripcion, a.fechaCarga, a.fechaNotificacion " +
                                                "from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                                "join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                                "join Colaborador c on c.legajo = ac.legajoColaborador " +
                                                "where MONTH(a.fechaOcurrencia) = MONTH(GETDATE())";
                        command.CommandType = CommandType.Text;

                        resultado.Load(command.ExecuteReader());
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }

        public DataTable getAllAvisosHoy()
        {
            DataTable resultado = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT a.id_aviso, ta.nombre, c.nombre, c.mail, a.fechaOcurrencia, a.descripcion" +
                                                "from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                                "join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                                "join Colaborador c on c.legajo = ac.legajoColaborador " +
                                                "where a.fechaOcurrencia = GETDATE() or (a.fechaOcurrencia < GETDATE() and a.fechaNotificacion is null)";
                        command.CommandType = CommandType.Text;

                        resultado.Load(command.ExecuteReader());
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }

        public DataTable getAllAvisos(int legajo, int idTipoAviso, string fechaOcurrencia, string fechaCarga, string fechaNotificacion, bool filtroFecha)
        {
            string parametros = "";
            if(legajo != 0)
            {
                parametros += " AND ac.legajoColaborador = " + legajo;
            }
            if(idTipoAviso != 0)
            {
                parametros += " AND ta.id_tipoAviso = " + idTipoAviso;
            }
            if(filtroFecha)
            {
                parametros += " AND a.fechaCarga >= '" + fechaCarga + "'";
            }
            if (filtroFecha)
            {
                parametros += " AND a.fechaOcurrencia >= '" + fechaOcurrencia + "'";
            }
            if (filtroFecha)
            {
                parametros += " AND a.fechaNotificacion >= '" + fechaNotificacion + "'";
            }
            DataTable resultado = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT a.id_aviso, ta.nombre, c.legajo,  a.fechaOcurrencia, a.descripcion, a.fechaCarga, a.fechaNotificacion " +
                                            "from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                            "join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                            "join Colaborador c on c.legajo = ac.legajoColaborador AND a.borradoLogico = 0" + parametros;
                        command.CommandType = CommandType.Text;

                        resultado.Load(command.ExecuteReader());
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }
        public DataTable getAvisosHoyColab(string legajo)
        {
            DataTable resultado = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT a.id_aviso, ta.nombre,  a.descripcion, a.fechaOcurrencia" +
                                            " from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                            " join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                            " join Colaborador c on c.legajo = ac.legajoColaborador " +
                                            " where c.legajo = @legajo and (a.fechaOcurrencia = CAST(GETDATE() AS Date) or (a.fechaOcurrencia < CAST(GETDATE() AS Date) and a.fechaNotificacion is null))";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@legajo", legajo);
                        resultado.Load(command.ExecuteReader());
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }

        public DataTable getLegajosAvisosHoy()
        {
            DataTable resultado = new DataTable();
            try
            {
                
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT DISTINCT c.legajo,c.nombre, c.mail " +
                                            "from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                            "join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                            "join Colaborador c on c.legajo = ac.legajoColaborador " +
                                            "where a.fechaOcurrencia = CAST(GETDATE() AS Date) or (a.fechaOcurrencia < CAST( GETDATE() AS Date ) and a.fechaNotificacion is null)";
                        command.CommandType = CommandType.Text;
                        resultado.Load(command.ExecuteReader());
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }

        public string GetHtmlTable(string title, DataTable table)
        {
            try
            {
                string messageBody = "<font> " + title + " </font><br><br>";

                if (table.Rows.Count == 0)
                    return messageBody;
                string htmlTableStart = "<table style=\"border-collapse:collapse; text-align:center;\" >";
                string htmlTableEnd = "</table>";
                string htmlHeaderRowStart = "<tr style =\"background-color:#6FA1D2; color:#ffffff;\">";
                string htmlHeaderRowEnd = "</tr>";
                string htmlTrStart = "<tr style =\"color:#555555;\">";
                string htmlTrEnd = "</tr>";
                string htmlTdStart = "<td style=\" border-color:#5c87b2; border-style:solid; border-width:thin; padding: 5px;\">";
                string htmlTdEnd = "</td>";

                messageBody += htmlTableStart;

                messageBody += htmlHeaderRowStart;

                foreach (DataColumn column in table.Columns)
                    messageBody += htmlTdStart + column + htmlTdEnd;

                messageBody += htmlHeaderRowEnd;

                foreach (DataRow row in table.Rows)
                {
                    messageBody += htmlTrStart;


                    foreach (object item in row.ItemArray)
                    {
                        
                        messageBody += htmlTdStart;
                        messageBody += item.ToString();
                        messageBody += htmlTdEnd;
                    }
                    messageBody += htmlTrEnd;
                }
                messageBody += htmlTableEnd;


                return messageBody;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool notificarAvisosHoy()
        {
            try
            {

                DataTable legajos = this.getLegajosAvisosHoy();
                //Hay avisos cargados en este instante de este mes?
                if (legajos.Rows.Count == 0) { return true; }

                List<int> id_avisos = new List<int>(); 
                
                foreach (DataRow leg in legajos.Rows)
                {
                    DataTable avisos = this.getAvisosHoyColab(leg[0].ToString());

                    String titulo = leg[1].ToString() + ", nos comunicamos desde ETRA para notificarle de sus avisos del día de hoy: ";
                    string body = GetHtmlTable(titulo, avisos);
                    var mailService = new MailServices.SystemSupportMail();
                    mailService.sendMail(
                        subject: "ETRA: AVISOS",
                        body: body,
                        recipientMail: new List<string>{leg[2].ToString()},
                        isHtml: true
                        );

                    foreach (DataRow id in avisos.Rows)
                    {
                        this.actualizarAviso((int)id[0], DateTime.Now);
                    }
                }
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getAviso(int id)
        {
            DataTable resultado = new DataTable();
            try
            {

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select mail, nombre from Aviso a"+
                                               " join AvisoXColaborador ac on a.id_aviso = ac.id_aviso"+
                                               " join Colaborador c on c.legajo = ac.legajoColaborador" +
                                               " where a.id_aviso = @id";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id", id);
                        resultado.Load(command.ExecuteReader());
                        return resultado;
                    }
                }
            }
            catch (Exception ex)
            {
                return resultado;
            }
        }
        public bool notificarAviso(int id, string subject, string body )
        {
            
            try
            {
                DataTable aviso = getAviso(id);
                List<string> mails = new List<string>();
                var mailService = new MailServices.SystemSupportMail();
                foreach (DataRow row in aviso.Rows)
                {
                    mails.Add(row["mail"].ToString());
                }
                mailService.sendMail(
                    subject: subject,
                    body: body,
                    recipientMail: mails,
                    isHtml: false
                    );

                this.actualizarAviso(id, DateTime.Now);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }

        
    }
    
}
