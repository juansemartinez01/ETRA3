using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;


namespace DataAccesA
{   
    public class AvisosDao : ConnectionToSql
    {
        
        /*Insercion del aviso*/
        public string insertarAviso(int idTipoAviso, string descripcion, DateTime fechaOcurrencia, DateTime fechaNotificacion, Nullable<DateTime> fechaUltimaNotificacion = null)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        
                        command.CommandText = "INSERT INTO Aviso VALUES (@idTipoAviso,@descripcion,GETDATE(),Format(@fechaOcurrencia, 'yyyy - MM - dd'),Format(@fechaNotificacion, 'yyyy - MM - dd'),";
                        string aux = "null,0)";
                        if (fechaUltimaNotificacion != null) 
                        { 
                            aux = "Format(@fechaUltimaNotificacion, 'yyyy - MM - dd'),0)";
                            command.Parameters.AddWithValue("@fechaUltimaNotificacion", fechaUltimaNotificacion);
                        }
                        command.CommandText += aux;
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

        public bool actualizarAviso(int id_aviso, DateTime fechaUtlimaNotificacion)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Aviso set fechaUltimaNotificacion = Format(@fechaUtlimaNotificacion, 'yyyy - MM - dd') WHERE id_aviso = @id_aviso";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id_aviso", id_aviso);
                        command.Parameters.AddWithValue("@fechaUtlimaNotificacion", fechaUtlimaNotificacion);
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
                        command.CommandText = "SELECT ta.nombre, c.legajo,  a.fechaOcurrencia, a.descripcion, a.fechaCarga, a.fechaNotificacion, a.fechaUltimaNotificacion " +
                                                "from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                                "join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                                "join Colaborador c on c.legajo = ac.legajoColaborador " +
                                                "where MONTH(a.fechaOcurrencia) = MONTH(GETDATE()) AND a.borradoLogico = 0";
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
                if(fechaOcurrencia != null)
                {
                    parametros += " AND a.fechaOcurrencia >= '" + fechaOcurrencia + "'";

                }
                if(fechaCarga != null)
                {
                    parametros += " AND a.fechaCarga >= '" + fechaCarga + "'";
                }

                if(fechaNotificacion != null)
                {
                    parametros += " AND a.fechaNotificacion >= '" + fechaNotificacion + "'";
                }
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
                        command.CommandText = "SELECT a.id_aviso, ta.nombre, c.legajo,  a.fechaOcurrencia, a.descripcion, a.fechaCarga, a.fechaNotificacion, a.fechaUltimaNotificacion " +
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
            //busca los avios con fechaOcurrencia = hoy y los aviso con fechaNotificaicon = hoy 
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
                                            " where c.legajo = @legajo and ((a.fechaOcurrencia = CAST(GETDATE() AS Date) and a.fechaUltimaNotificacion != CAST(GETDATE() AS Date)) or (a.fechaOcurrencia < CAST(GETDATE() AS Date) and a.fechaUltimaNotificacion is null) or (a.fechaNotificacion = CAST(GETDATE() AS Date)) and a.fechaUltimaNotificacion != CAST(GETDATE() AS Date))";
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
                                            "where (a.fechaOcurrencia = CAST(GETDATE() AS Date) and a.fechaUltimaNotificacion != CAST(GETDATE() AS Date)) or (a.fechaNotificacion < CAST( GETDATE() AS Date ) and a.fechaUltimaNotificacion is null) or (a.fechaNotificacion = CAST(GETDATE() AS DATE) AND a.fechaUltimaNotificacion != CAST(GETDATE() AS DATE))";
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

                    String titulo = leg[1].ToString() + ", nos comunicamos desde ETRA para notificarle de sus avisos : ";
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
                    //Evitamos spam pausando 1 segundo antes de enviar el prox mail
                    System.Threading.Thread.Sleep(1000);
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
                List<string> mails = new List<string>(  );
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

        public bool consultarAvisoAdmin()
        {
            
            try
            {

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //Busca el aviso con id 1 que corresponde a los avisos a los admins, y verifica que la ultima fecha de notificacion sea hace mas de dos semanas
                        command.CommandText = "select 1 from Aviso where id_aviso = 1 and ( DATEDIFF(D,fechaUltimaNotificacion,CAST(GETDATE() AS DATE)) >= 15 OR fechaUltimaNotificacion is null )";
                        command.CommandType = CommandType.Text;
                        return command.ExecuteReader().HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool consultarAvisoCumple()
        {

            try
            {

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select 1 from Aviso where id_aviso = 2 and ( MONTH(fechaUltimaNotificacion) = MONTH(GETDATE()) or fechaUltimaNotificacion is not null)";
                        command.CommandType = CommandType.Text;
                        return command.ExecuteReader().HasRows;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public DataTable getAvisosEntre(DateTime desde, DateTime hasta)
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
                        command.CommandText = "SELECT a.id_aviso, ta.nombre, c.legajo,  a.fechaOcurrencia, a.descripcion, a.fechaCarga, a.fechaNotificacion " +
                                            "from Aviso a join TipoAviso ta on ta.id_tipoAviso = a.id_tipoAviso " +
                                            "join AvisoXColaborador ac on ac.id_aviso = a.id_aviso " +
                                            "join Colaborador c on c.legajo = ac.legajoColaborador where a.borradoLogico = 0 AND CAST('"+desde.ToString("yyyy-MM-dd")+ "' AS datetime) <= CAST(a.fechaOcurrencia AS datetime) and CAST(a.fechaOcurrencia AS datetime) <= CAST('" + hasta.ToString("yyyy-MM-dd") + "'  AS datetime) and a.id_aviso > 2";
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
        public bool notificarAdmins()
        {
            //Notifica a los administradores los avisos de las proximas dos semanas
            try {
                //Ya fue enviada la notificacion?
                if (this.consultarAvisoAdmin() == false) { return true; }
                ColaboradorDao colab = new ColaboradorDao();
                DataTable avisos = getAvisosEntre(DateTime.Now, DateTime.Now.AddDays(15));
                //Hay avisos en las proximas dos semanas? 
                if(avisos.Rows.Count > 0)
                {
                    String titulo = "Administradores, les enviamos un resumen de los avisos de las proximas dos semanas: ";
                    string body = GetHtmlTable(titulo, avisos);
                    var mailService = new MailServices.SystemSupportMail();
                    mailService.sendMail(
                        subject: "ETRA: AVISOS",
                        body: body,
                        recipientMail: colab.getAdmins(),
                        isHtml: true
                        );
                    this.actualizarAviso(1,DateTime.Now);
                }
                return true;
            }
            catch { return false; }
            
        }

        public bool insertarAvisosCumple()
        {
            try
            {
                //Consultar si ya fueron cargados los cumpleaños de este mes
                if(consultarAvisoCumple() == true) { return true; }    
                //Busca los cumpleaños de este mes
                ColaboradorDao colab = new ColaboradorDao();
                DataTable cumpleaños = colab.getCumpleañosMesActual();
                FamiliarColaboradorDao fam = new FamiliarColaboradorDao();
                DataTable cumpleFami = fam.getCumpleañosMesActual();
                //hay cumpleaños este mes?
                if (cumpleaños.Rows.Count == 0 & cumpleFami.Rows.Count == 0) {  return true; }
                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                        
                            command.Connection = connection;
                            string query = "";
                            string cumple = "";
                            foreach(DataRow row in cumpleaños.Rows) 
                            {
                                    //MODIFICAR VALOR DE TIPO AVISO
                                cumple = DateTime.Now.Year.ToString() + "/" + row["fechaNacimiento"].ToString().Substring(3,3) + row["fechaNacimiento"].ToString().Substring(0, 2);
                                query += " INSERT INTO Aviso VALUES (3, 'Cumpleaños de colaborador', GETDATE(), Format(CAST('" + cumple + "' AS DATE), 'yyyy - MM - dd'), Format(CAST('" + cumple + "' AS DATE),'yyyy - MM - dd'),null, 0) " +
                                         " INSERT INTO AvisoXColaborador VALUES (CAST('" + row["legajo"].ToString() + "' AS INT),(SELECT MAX(id_aviso) FROM Aviso WHERE borradoLogico = 0),0)";
                            }

                            foreach (DataRow row in cumpleFami.Rows)
                            {
                                //MODIFICAR VALOR DE TIPO AVISO
                                cumple = DateTime.Now.Year.ToString() + "/" + row["fechaNacimiento"].ToString().Substring(3, 3) + row["fechaNacimiento"].ToString().Substring(0, 2);
                                query += " INSERT INTO Aviso VALUES (5, 'Cumpleños del familiar:  " + row["nombreFamiliar"] + "', GETDATE(), Format(CAST('" + cumple + "' AS DATE), 'yyyy - MM - dd'), Format(CAST('" + cumple + "' AS DATE),'yyyy - MM - dd'),null, 0) " +
                                         " INSERT INTO AvisoXColaborador VALUES (CAST('" + row["legajoColaborador"].ToString() + "' AS INT),(SELECT MAX(id_aviso) FROM Aviso WHERE borradoLogico = 0),0)";
                            }

                            command.CommandText = query;
                            command.CommandType = CommandType.Text;
                            command.ExecuteNonQuery();
                            actualizarAviso(2,DateTime.Now);
                        }
                    }
                
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public int eliminarAvisoLogico(int idAviso)
        {
            int avisoEliminado = 0;
            int resultadoModificacion = 0;
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Aviso set borradoLogico = 1 WHERE id_aviso = @id_aviso";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@id_aviso", idAviso);     
                        avisoEliminado = command.ExecuteNonQuery();
                    }
                    if (avisoEliminado == 1)
                    {
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "UPDATE AvisoXColaborador set borradoLogico = 1 WHERE id_aviso = @id_aviso";
                            command.CommandType = CommandType.Text;
                            command.Parameters.AddWithValue("@id_aviso", idAviso);
                            resultadoModificacion = command.ExecuteNonQuery();
                            return resultadoModificacion;
                        }
                    }
                    else
                    {
                        return avisoEliminado;
                    }
                }
                
            }
            catch (Exception ex)
            {
                return resultadoModificacion;
            }
        }
    }
    
}
