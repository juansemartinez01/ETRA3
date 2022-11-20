using System;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using Common.Cache;

namespace DataAccesA
{
    public class UsuarioDao : ConnectionToSql
    {
        public bool Login(string user, string pass)
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
                        command.CommandText = "select * from Usuario where nombre=@nombre";
                        command.Parameters.AddWithValue("@nombre", userRequesting);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        Random rnd = new Random();
                        string code = rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString() + rnd.Next(10).ToString();
                        if (reader.Read() == true)
                        {
                            string userMail = reader.GetString(2);
                            string passMail = reader.GetString(3);

                            var mailService = new MailServices.SystemSupportMail();
                            mailService.sendMail(
                                subject: "ETRA: Solicitud de recuperar contraseña",
                                body: "Hola, userName este es su codigo para cambiar la contraseña: " + code,
                                recipientMail: new List<string> { userMail }
                                );
                            result.Add("Hola, userName \r\nYa hemos enviado su solicitud para recuperar la contraseña.\r\n" + "Por favor, revise su casilla de correo: " + userMail);
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
        public string updatePassword(string user, string pass)
        {
            try
            {
                using (var connection = GetConnection())
                {

                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "UPDATE Usuario set contraseña = @pass WHERE nombre = @user";
                        command.Parameters.AddWithValue("@user", user);
                        command.Parameters.AddWithValue("@pass", pass);
                        command.CommandType = CommandType.Text;
                        command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                        return "";
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }
    }
}
