using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DataAccesA
{
    public class NotificacionesGeneralesDao:ConnectionToSql
    {

        public string[] notificacionesDeCumpleaños()
        {
            DataTable cumpleañosColaboradores = new DataTable();

            string[] cumpleañosCercanos = {};
            //colaboradorArray[0] = "";
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT fechaNacimiento AS 'Cumpleaños',nombre AS 'Nombre',apellido AS 'Apellido' FROM Colaborador WHERE fechaNacimiento IS NOT NULL";
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        cumpleañosColaboradores.Load(reader);

                        foreach (DataRow row in cumpleañosColaboradores.Rows)
                        {
                            foreach (DataColumn column in cumpleañosColaboradores.Columns)
                            {
                                int diaCumpleañosColaborador = DateTime.Parse(row["Cumpleaños"].ToString()).Day;
                                int semanaDesdeCumpleaños = DateTime.Parse(row["Cumpleaños"].ToString()).AddDays(-7).Day;
                                int diaActual = DateTime.Now.Day;
                                int mesCumpleañosColaborador = DateTime.Parse(row["Cumpleaños"].ToString()).Month;
                                int mesActual = DateTime.Now.Month;
                                
                                //cumpleañosColaborador = cumpleañosColaborador.AddDays(7);
                                

                                if(mesCumpleañosColaborador == mesActual || mesCumpleañosColaborador + 1 == mesActual)
                                {
                                    if((diaActual >= semanaDesdeCumpleaños && diaActual <= diaCumpleañosColaborador && mesActual == mesCumpleañosColaborador))
                                    {
                                        string newElement = "";
                                        int diasRestantes = diaCumpleañosColaborador - diaActual;

                                        //Agregar el string al array
                                        if(diasRestantes == 0)
                                        {
                                            newElement = "El cumpleaños de " + row["Nombre"].ToString() + " " + row["Apellido"].ToString() + " es hoy.";
                                        }
                                        else 
                                        {
                                            newElement = "Faltan " + diasRestantes + " dias para el cumpleaños de " + row["Nombre"].ToString() + " " + row["Apellido"].ToString() + ".";

                                        }
                                        
                                        List<string> list = new List<string>(cumpleañosCercanos.ToList());
                                        list.Add(newElement);
                                        cumpleañosCercanos = list.ToArray();


                                        return cumpleañosCercanos;




                                    }
                                    else if (diaActual >= semanaDesdeCumpleaños && mesCumpleañosColaborador == mesActual + 1)
                                    {
                                        string newElement = "El cumpleaños de " + row["Nombre"].ToString() + " " + row["Apellido"].ToString() + " es en menos de una semana.("+ row["Cumpleaños"].ToString() +").";
                                        List<string> list = new List<string>(cumpleañosCercanos.ToList());
                                        list.Add(newElement);
                                        cumpleañosCercanos = list.ToArray();
                                        return cumpleañosCercanos;

                                    }
                                    return cumpleañosCercanos;
                                }
                                
                            }
                            
                        }
                        return cumpleañosCercanos;

                    }
                }
            }
            catch (Exception ex)
            {
                return cumpleañosCercanos;
            }
        }
    }
}
