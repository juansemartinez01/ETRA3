using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesA
{
    public class ColaboradorDao : ConnectionToSql
    {
        public DataTable BuscarColaborador(string legajo, string nombre, string apellido)
        {
            DataTable colaborador = new DataTable();
            //colaboradorArray[0] = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        //if (nombre != "" || apellido != "")
                        //{
                        //    command.CommandText = "SELECT legajo, c.nombre, apellido, mail,CONVERT(varchar,fechaNacimiento, 103) AS fechaNacimiento,d.nombreCalle,d.numeroCalle, d.piso,isnull(d.departamento,' ')AS departamento ,isnull(d.localidad,' ') AS localidad,isnull(d.provincia,' ') AS provincia,EC.nombre AS nombreEstado, CA.nombre AS nombreCargo, SA.monto AS montoSalario,d.piso AS piso, d.departamento AS depto, d.localidad AS localidad, d.provincia AS provincia,C.dni as Dni,C.obraSocial as ObraSocial FROM Colaborador c JOIN Direccion d ON d.id_direccion = c.idDireccion JOIN HistorialEstado HE ON HE.legajoColaborador = c.legajo JOIN HistorialCargo HC ON HC.legajoColaborador = c.legajo JOIN HistorialSalario HS ON HS.legajoColaborador = c.legajo JOIN EstadoColaborador EC ON EC.id_estado = HE.id_estado JOIN Cargo CA ON CA.id_cargo = HC.id_cargo JOIN Salario SA ON SA.id_salario = HS.id_salario WHERE c.nombre LIKE @nombre AND c.apellido LIKE @apellido AND c.borradoLogico = 0 AND HS.fechaFin IS NULL AND HC.fechaFin IS NULL AND HE.fechaFin IS NULL";
                        //    command.Parameters.AddWithValue("@nombre", nombre + '%');
                        //    command.Parameters.AddWithValue("@apellido", apellido + '%');
                        //}
                        //else
                        //{
                        //    command.CommandText = "SELECT legajo, c.nombre, apellido, mail,CONVERT(varchar,fechaNacimiento, 103) AS fechaNacimiento,d.nombreCalle,d.numeroCalle, d.piso,isnull(d.departamento,' ')AS departamento ,isnull(d.localidad,' ') AS localidad,isnull(d.provincia,' ') AS provincia,EC.nombre AS nombreEstado, CA.nombre AS nombreCargo, SA.monto AS montoSalario,d.piso AS piso, d.departamento AS depto, d.localidad AS localidad, d.provincia AS provincia,C.dni as Dni,C.obraSocial as ObraSocial FROM Colaborador c JOIN Direccion d ON d.id_direccion = c.idDireccion JOIN HistorialEstado HE ON HE.legajoColaborador = c.legajo JOIN HistorialCargo HC ON HC.legajoColaborador = c.legajo JOIN HistorialSalario HS ON HS.legajoColaborador = c.legajo JOIN EstadoColaborador EC ON EC.id_estado = HE.id_estado JOIN Cargo CA ON CA.id_cargo = HC.id_cargo JOIN Salario SA ON SA.id_salario = HS.id_salario WHERE legajo LIKE @legajo AND c.borradoLogico = 0 AND HS.fechaFin IS NULL AND HC.fechaFin IS NULL AND HE.fechaFin IS NULL";
                        //    command.Parameters.AddWithValue("@legajo", legajo.ToString() + '%');
                        //}

                        command.CommandText = "SELECT legajo, c.nombre, apellido,CUIT AS Cuit,nroContacto AS NroCont,nroEmergencia AS NroEmer, mail,CONVERT(varchar,fechaNacimiento, 103) AS FechaNac,d.nombreCalle,d.numeroCalle, EC.nombre AS nombreEstado, CA.nombre AS nombreCargo, SA.monto AS montoSalario,d.piso AS piso, d.departamento AS Depto, d.localidad AS localidad, d.provincia AS provincia,C.dni as Dni,C.obraSocial as ObraSocial FROM Colaborador c JOIN Direccion d ON d.id_direccion = c.idDireccion JOIN HistorialEstado HE ON HE.legajoColaborador = c.legajo JOIN HistorialCargo HC ON HC.legajoColaborador = c.legajo JOIN HistorialSalario HS ON HS.legajoColaborador = c.legajo JOIN EstadoColaborador EC ON EC.id_estado = HE.id_estado JOIN Cargo CA ON CA.id_cargo = HC.id_cargo JOIN Salario SA ON SA.id_salario = HS.id_salario WHERE legajo LIKE @legajo AND c.nombre LIKE @nombre AND c.apellido LIKE @apellido AND c.borradoLogico = 0 AND HS.fechaFin IS NULL AND HC.fechaFin IS NULL AND HE.fechaFin IS NULL";
                        command.Parameters.AddWithValue("@legajo", legajo + "%");
                        command.Parameters.AddWithValue("@nombre", nombre + "%");
                        command.Parameters.AddWithValue("@apellido", apellido + "%");

                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        colaborador.Load(reader);
                        return colaborador;
                    }
                }
            }
            catch (Exception ex)
            {
                return colaborador;
            }
        }



        public string BuscarLegajoUltimoColaborador()
        {

            try
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
        public string AgregarDocumento(string Nombre, byte[] Documento, string Extension, int TipoMultimedia, int Legajo,int idEvento)
        {
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO ColaboradorMultimedia VALUES (@nombre, @documento, @extension, @tipo, @legajoColaborador,0,@idEvento)";
                        command.CommandType = CommandType.Text;
                        command.Parameters.AddWithValue("@nombre", Nombre);
                        command.Parameters.AddWithValue("@documento", Documento);
                        command.Parameters.AddWithValue("@extension", Extension);
                        command.Parameters.AddWithValue("@tipo", TipoMultimedia);
                        command.Parameters.AddWithValue("@legajoColaborador", Legajo);
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        command.ExecuteNonQuery();
                        return "Documento agregado con exito";



                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataTable BuscarDocumento(int TipoMultimedia, int Legajo)
        {
            DataTable tabla = new DataTable();
            try
            {


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
            catch (Exception ex)
            {
                return tabla;
            }
        }
        public DataTable BuscarDocumentoEvento(int idEvento)
        {
            DataTable tabla = new DataTable();
            try
            {


                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM ColaboradorMultimedia WHERE id_evento = @idEvento AND borradoLogico = 0";
                        command.CommandType = CommandType.Text;
                        
                        command.Parameters.AddWithValue("@idEvento", idEvento);
                        SqlDataReader lector = command.ExecuteReader();
                        tabla.Load(lector);
                        return tabla;



                    }
                }
            }
            catch (Exception ex)
            {
                return tabla;
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
        public int CrearColaborador(string nombre, string apellido, int dni, string cuit, string calle, int numeroCalle, int puesto, int piso, string departamento, string localidad, string provincia, int estado)
        {
            try
            {


                int esEdificio;
                if (piso == 0)
                {

                    esEdificio = 0;

                    departamento = "NULL";
                }
                else
                {
                    esEdificio = 1;
                }

                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO DIRECCION (nombreCalle,numeroCalle,esEdificio,piso,departamento,localidad,provincia,borradoLogico) VALUES (@nombreCalle,@numeroCalle,@esEdificio,@piso,@departamento,@localidad,@provincia,0)";
                        command.Parameters.AddWithValue("@nombreCalle", calle);
                        command.Parameters.AddWithValue("@numeroCalle", numeroCalle);
                        command.Parameters.AddWithValue("@esEdificio", esEdificio);
                        command.Parameters.AddWithValue("@piso", piso);
                        command.Parameters.AddWithValue("@departamento", departamento);
                        command.Parameters.AddWithValue("@localidad", localidad);
                        command.Parameters.AddWithValue("@provincia", provincia);
                        command.CommandType = CommandType.Text;
                        var direccionCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        if (direccionCreada == 1)
                        {
                            using (var command2 = new SqlCommand())
                            {
                                command2.Connection = connection;
                                command2.CommandText = "INSERT INTO Colaborador (nombre,apellido,idDireccion,fechaIngreso,borradoLogico,dni,CUIT) VALUES (@nombre,@apellido,(SELECT MAX(id_direccion) FROM Direccion),GETDATE(),0,@dni,@CUIT)";
                                command2.Parameters.AddWithValue("@dni", dni);
                                command2.Parameters.AddWithValue("@CUIT", cuit);
                                command2.Parameters.AddWithValue("@nombre", nombre);
                                command2.Parameters.AddWithValue("@apellido", apellido);
                                command2.CommandType = CommandType.Text;

                                var colaboradorCreado = command2.EndExecuteNonQuery(command2.BeginExecuteNonQuery());
                                int legajo = int.Parse(BuscarLegajoUltimoColaborador());
                                if (colaboradorCreado == 1)
                                {
                                    using (var command3 = new SqlCommand())
                                    {

                                        command3.Connection = connection;
                                        command3.CommandText = "INSERT INTO Salario VALUES (19900,0)";

                                        command3.CommandType = CommandType.Text;
                                        var SalarioCreado = command3.EndExecuteNonQuery(command3.BeginExecuteNonQuery());
                                        if (SalarioCreado != 0)
                                        {
                                            int idUltimoSalario = int.Parse(BuscarIdUltimoSalario());
                                            using (var command4 = new SqlCommand())
                                            {

                                                command4.Connection = connection;
                                                command4.CommandText = "INSERT INTO HistorialSalario VALUES (GETDATE(),NULL,@id_salario,@legajo,0)";
                                                command4.Parameters.AddWithValue("@legajo", legajo);
                                                command4.Parameters.AddWithValue("@id_salario", idUltimoSalario);
                                                command4.CommandType = CommandType.Text;
                                                var HistorialSalarioCreado = command4.EndExecuteNonQuery(command4.BeginExecuteNonQuery());
                                                if (HistorialSalarioCreado != 0)
                                                {
                                                    using (var command5 = new SqlCommand())
                                                    {

                                                        command5.Connection = connection;
                                                        command5.CommandText = "INSERT INTO Evento VALUES (@descripcion,1,0)";
                                                        command5.Parameters.AddWithValue("@descripcion", "Bienvenido " + nombre + " " + apellido + ".");

                                                        command5.CommandType = CommandType.Text;
                                                        var EventoCreado = command5.EndExecuteNonQuery(command5.BeginExecuteNonQuery());
                                                        int idEvento = int.Parse(BuscarIdUltimoEvento());
                                                        if (EventoCreado != 0)
                                                        {
                                                            using (var command6 = new SqlCommand())
                                                            {

                                                                command6.Connection = connection;
                                                                command6.CommandText = "INSERT INTO HistorialEvento VALUES (@idEvento,GETDATE(),GETDATE(),GETDATE(),@legajo,0)";
                                                                command6.Parameters.AddWithValue("@legajo", legajo);
                                                                command6.Parameters.AddWithValue("@idEvento", idEvento);
                                                                command6.CommandType = CommandType.Text;
                                                                var HistorialEventoCreado = command6.EndExecuteNonQuery(command6.BeginExecuteNonQuery());
                                                                if (HistorialEventoCreado != 0)
                                                                {
                                                                    using (var command7 = new SqlCommand())
                                                                    {

                                                                        command7.Connection = connection;
                                                                        command7.CommandText = "INSERT INTO HistorialCargo VALUES (@cargo,GETDATE(),NULL,@legajo,0)";
                                                                        command7.Parameters.AddWithValue("@cargo", puesto);
                                                                        command7.Parameters.AddWithValue("@legajo", legajo);

                                                                        command6.CommandType = CommandType.Text;
                                                                        var HistorialCargoCreado = command7.EndExecuteNonQuery(command7.BeginExecuteNonQuery());
                                                                        if (HistorialCargoCreado != 0)
                                                                        {
                                                                            using (var command8 = new SqlCommand())
                                                                            {

                                                                                command8.Connection = connection;
                                                                                command8.CommandText = "INSERT INTO HistorialEstado VALUES (GETDATE(),NULL,@estado,@legajo,0)";
                                                                                command8.Parameters.AddWithValue("@legajo", legajo);
                                                                                command8.Parameters.AddWithValue("@estado", estado);
                                                                                command8.CommandType = CommandType.Text;
                                                                                var HistorialEstadoCreado = command8.EndExecuteNonQuery(command8.BeginExecuteNonQuery());
                                                                                if (HistorialEstadoCreado != 0)
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
        public int EliminarColaborador(int legajo)
        {
            try
            {


                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command8 = new SqlCommand())
                    {

                        command8.Connection = connection;
                        command8.CommandText = "UPDATE CuentaColaborador SET borradoLogico = 1 WHERE numeroCuenta IN (SELECT C.numeroCuenta FROM CuentaColaborador C JOIN HistorialCuentaColaborador H ON C.numeroCuenta = H.nroCuenta WHERE legajoColaborador = @legajo)";
                        command8.Parameters.AddWithValue("@legajo", legajo);
                        command8.CommandType = CommandType.Text;
                        var cuentaEliminada = command8.EndExecuteNonQuery(command8.BeginExecuteNonQuery());
                        
                        

                    }
                    using (var command9 = new SqlCommand())
                    {

                        command9.Connection = connection;
                        command9.CommandText = "UPDATE HistorialCuentaColaborador SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                        command9.Parameters.AddWithValue("@legajo", legajo);
                        command9.CommandType = CommandType.Text;
                        var HistorialCuentaeliminada = command9.EndExecuteNonQuery(command9.BeginExecuteNonQuery());



                    }
                    using (var command10 = new SqlCommand())
                    {

                        command10.Connection = connection;
                        command10.CommandText = "UPDATE FamiliarColaborador SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                        command10.Parameters.AddWithValue("@legajo", legajo);
                        command10.CommandType = CommandType.Text;
                        var HistorialCuentaeliminada = command10.EndExecuteNonQuery(command10.BeginExecuteNonQuery());



                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "UPDATE Colaborador SET borradoLogico = 1 WHERE legajo = @legajo";
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        var ColaboradorEliminado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());

                        using (var command1 = new SqlCommand())
                        {

                            command1.Connection = connection;
                            command1.CommandText = "UPDATE HistorialCargo SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                            command1.Parameters.AddWithValue("@legajo", legajo);
                            command1.CommandType = CommandType.Text;
                            var HistorialCargoEliminado = command1.EndExecuteNonQuery(command1.BeginExecuteNonQuery());

                            using (var command2 = new SqlCommand())
                            {

                                command2.Connection = connection;
                                command2.CommandText = "UPDATE HistorialEvento SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                command2.Parameters.AddWithValue("@legajo", legajo);
                                command2.CommandType = CommandType.Text;
                                var HistorialEventoEliminado = command2.EndExecuteNonQuery(command2.BeginExecuteNonQuery());

                                using (var command3 = new SqlCommand())
                                {

                                    command3.Connection = connection;
                                    command3.CommandText = "UPDATE HistorialEstado SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                    command3.Parameters.AddWithValue("@legajo", legajo);
                                    command3.CommandType = CommandType.Text;
                                    var HistorialEstadoEliminado = command3.EndExecuteNonQuery(command3.BeginExecuteNonQuery());

                                    using (var command4 = new SqlCommand())
                                    {

                                        command4.Connection = connection;
                                        command4.CommandText = "UPDATE HistorialSalario SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                        command4.Parameters.AddWithValue("@legajo", legajo);
                                        command4.CommandType = CommandType.Text;
                                        var HistorialSalarioEliminado = command4.EndExecuteNonQuery(command4.BeginExecuteNonQuery());

                                        using (var command5 = new SqlCommand())
                                        {

                                            command5.Connection = connection;
                                            command5.CommandText = "UPDATE ColaboradorMultimedia SET borradoLogico = 1 WHERE legajoColaborador = @legajo";
                                            command5.Parameters.AddWithValue("@legajo", legajo);
                                            command5.CommandType = CommandType.Text;
                                            var ColaboradorMultimediaEliminado = command5.EndExecuteNonQuery(command5.BeginExecuteNonQuery());

                                            using (var command6 = new SqlCommand())
                                            {

                                                command6.Connection = connection;
                                                command6.CommandText = "UPDATE Evento SET borradoLogico = 1 WHERE id_evento IN (SELECT E.id_evento FROM HistorialEvento H JOIN Evento E ON H.id_evento = E.id_evento WHERE h.borradoLogico = 1)";
                                                command6.CommandType = CommandType.Text;
                                                var EstadoEliminado = command6.EndExecuteNonQuery(command6.BeginExecuteNonQuery());

                                                using (var command7 = new SqlCommand())
                                                {

                                                    command7.Connection = connection;
                                                    command7.CommandText = "UPDATE Salario SET borradoLogico = 1 WHERE id_salario IN (SELECT S.id_salario FROM HistorialSalario H JOIN Salario S ON H.id_salario = S.id_salario WHERE h.borradoLogico = 1)";
                                                    command7.CommandType = CommandType.Text;
                                                    var SalarioEliminado = command7.EndExecuteNonQuery(command7.BeginExecuteNonQuery());
                                                    int algunaModificacion = SalarioEliminado + EstadoEliminado + ColaboradorMultimediaEliminado + HistorialSalarioEliminado + HistorialEstadoEliminado + HistorialEventoEliminado + HistorialCargoEliminado + ColaboradorEliminado;
                                                    if (algunaModificacion == 0)
                                                    {
                                                        return 0;
                                                    }
                                                    else
                                                    {
                                                        return 1;
                                                    }

                                                }



                                            }



                                        }



                                    }



                                }



                            }



                        }



                    }
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
        public string EliminarColaboradorPermanentemente()
        {
            int algunDelete = 0;
            try
            {


                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM FamiliarColaborador WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        


                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM CuentaColaborador WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());



                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM MovimientosCuentaColaborador WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());



                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM HistorialEvento WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM ColaboradorMultimedia WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM Evento WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM HistorialCargo WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM HistorialEstado WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }

                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM HistorialSalario WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM Salario WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());

                    }
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "DELETE FROM Colaborador WHERE borradoLogico = 1";
                        command.CommandType = CommandType.Text;
                        algunDelete += command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    }
                    if(algunDelete == 0)
                    {
                        return "No se elimino ningun elemento de la base de datos.";
                    }
                    else
                    {
                        return "Se eliminaron elementos de la base de datos";
                    }       
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public DataTable getAllDocumentos(int legajoColaborador,int tipoDocumento, int tipoEvento, DateTime fecha, bool aplicarFecha)
        {

            DataTable documentos = new DataTable();
            string parametrosAdicionales = "";
            
            if (aplicarFecha) 
            {
                fecha = DateTime.Parse(fecha.ToShortDateString());
                parametrosAdicionales = parametrosAdicionales + "AND HE.fechaRegistro >= " + "Format(" + fecha + ", 'yyyy - MM - dd')";
            }
            if(legajoColaborador != 0)
            {
                parametrosAdicionales = parametrosAdicionales + "AND CM.legajoColaborador = " + legajoColaborador;
            }
            if(tipoDocumento != 0)
            {
                parametrosAdicionales = parametrosAdicionales + "AND TM.id_tipoMultimedia = " + tipoDocumento;
            }
            if (tipoEvento != 0)
            {
                parametrosAdicionales = parametrosAdicionales + "AND TE.id_tipoEvento = " + tipoEvento;
            }
            try
            {
                
                

                    using (var connection = GetConnection())
                    {
                        connection.Open();
                        using (var command = new SqlCommand())
                        {
                            command.Connection = connection;
                            command.CommandText = "SELECT CM.id_colaboradorMultimedia AS 'Numero',CM.legajoColaborador AS 'Legajo',TM.nombre AS 'Tipo doc',TE.nombre AS 'Evento',HE.fechaRegistro AS 'Fecha Registro' FROM ColaboradorMultimedia CM JOIN TipoMultimedia TM ON CM.id_tipoMultimedia = TM.id_tipoMultimedia JOIN Evento E ON CM.id_evento = E.id_evento JOIN TipoEvento TE ON TE.id_tipoEvento = E.id_tipoEvento JOIN HistorialEvento HE ON HE.id_evento = E.id_evento WHERE CM.borradoLogico = 0 AND E.borradoLogico = 0 AND TE.borradoLogico = 0 AND TM.borradoLogico = 0" + " " + parametrosAdicionales;
                            command.CommandType = CommandType.Text;
                            SqlDataReader reader = command.ExecuteReader();
                            documentos.Load(reader);
                            return documentos;
                        }
                    }




                









            }catch(Exception ex)
            {
                return documentos;
            }
        }

    }
}
