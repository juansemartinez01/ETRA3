using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Common.Cache;
using System.Threading;

namespace DataAccesA
{
    public class UsuarioDao : ConnectionToSql
    {
        public String Login(string user, string pass)
        {
            try
            {


                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT * FROM Usuario WHERE mail = @user AND contraseña = @pass";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read()) {
                                UserCache.perfil = reader.GetInt32(1);
                                UserCache.mail = reader.GetString(2);   
                            }
                            return "Exito";
                        }
                        else
                        {
                            return "Datos incorrectos";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public List<string> recoverPassword(string userRequesting)
        {
            List<string> result = new List<string>();
            try
            {
                using (var connection = GetConnection())
                {
                    
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "select c.nombre,u.mail,u.contraseña from Usuario u join Colaborador c on c.mail = u.mail where u.mail=@mail";
                        command.Parameters.AddWithValue("@mail", userRequesting);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        Random rnd = new Random();
                        string code = rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();
                        if (reader.Read() == true)
                        {
                            string userName = reader.GetString(0);
                            string userMail = reader.GetString(1);
                            string passMail = reader.GetString(2);

                            var mailService = new MailServices.SystemSupportMail();
                            mailService.sendMail(
                                subject: "ETRA: Solicitud de recuperar contraseña",
                                body: "Hola, " +  userName + " este es su codigo para cambiar la contraseña: " + code,
                                recipientMail: new List<string> { userMail }
                                );
                            result.Add("Hola, " +  userName + " \r\nYa hemos enviado su solicitud para recuperar la contraseña.\r\n" + "Por favor, revise su casilla de correo: " + userMail);
                            result.Add(code);
                            return result;

                        }
                        else
                            result.Add("Lo sentimos, \r\nNo hay ningun usuario registrado con ese correo electronico");
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                result.Add("Ocurrio un error: " + ex.ToString());
                return result;
            }
        }
        public bool updatePassword(string user, string pass)
        {
            try
            {
                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Usuario set contraseña = @pass WHERE mail = @user";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable getAllUsuarios(int legajo)
        {
            string cadenaFiltros = "";
            
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT legajoColaborador,P.nombre, mail FROM Usuario U JOIN Perfil P ON U.id_perfil = P.id_perfil WHERE U.borradoLogico = 0 AND P.borradoLogico = 0 AND legajoColaborador LIKE @legajo";
                    command.Parameters.AddWithValue("@legajo", legajo + "%");
                    
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }

        }
        public string crearNuevoUsuario(int idPerfil,string mail,string contraseña,int legajo)
        {
            try
            {
                int usuarioCreado = 0;
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Usuario VALUES (@idPerfil,@mail,@contraseña,@legajo,0)";
                        command.Parameters.AddWithValue("@idPerfil", idPerfil);
                        command.Parameters.AddWithValue("@mail", mail);
                        command.Parameters.AddWithValue("@contraseña", contraseña);
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        usuarioCreado = command.ExecuteNonQuery();
                        if (usuarioCreado != 1)
                        {
                            return "Error al crear el usuario.";
                        }
                        else
                        {
                            return "Usuario creado con exito.";
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string modificarUsuario(int idPerfil, int legajo)
        {
            try
            {
                int usuarioCreado = 0;
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "UPDATE Usuario SET id_perfil = @idPerfil, mail = (select mail from Colaborador where legajo = @legajo) WHERE legajoColaborador = @legajo";
                        command.Parameters.AddWithValue("@idPerfil", idPerfil);
                        command.Parameters.AddWithValue("@legajo", legajo);
                        command.CommandType = CommandType.Text;
                        usuarioCreado = command.ExecuteNonQuery();
                        if (usuarioCreado != 1)
                        {
                            return "Error al modificar el usuario.";
                        }
                        else
                        {
                            return "Usuario modificado con exito.";
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
