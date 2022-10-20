using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading;

namespace DataAccessA
{
    public class SalariosDao : ConnectionToSql
    {
        public DataTable obtenerSalarios(string legajo)
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT S.monto AS 'Monto', CONVERT(varchar,H.fechaInicio,103) AS 'Fecha de Inicio',CONVERT(varchar,H.fechaFin,103) AS 'Fecha Fin' FROM HistorialSalario H JOIN Salario S ON H.id_salario = S.id_salario WHERE H.legajoColaborador = @legajo AND H.borradoLogico = 0 AND S.borradoLogico = 0";
                    command.Parameters.AddWithValue("@legajo", legajo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
        public int modificarSalarioColaborador(int legajo, float monto)
        {
            try
            {


                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Salario VALUES (@monto,0)";
                        command.Parameters.AddWithValue("@monto", monto);
                        command.CommandType = CommandType.Text;
                        int salarioCreado = command.ExecuteNonQuery();
                        if (salarioCreado == 1)
                        {
                            using (var command1 = new SqlCommand())
                            {
                                command1.Connection = connection;
                                command1.CommandText = "UPDATE HistorialSalario SET fechaFin = GETDATE() WHERE legajoColaborador = @legajo AND fechaFin IS NULL";
                                command1.Parameters.AddWithValue("@legajo", legajo);
                                command1.CommandType = CommandType.Text;
                                int historialSalarioActualizado = command1.ExecuteNonQuery();
                                if (historialSalarioActualizado == 1)
                                {
                                    using (var command2 = new SqlCommand())
                                    {
                                        int idUltimoSalario = int.Parse(BuscarIdUltimoSalario());
                                        command2.Connection = connection;
                                        command2.CommandText = "INSERT INTO HistorialSalario VALUES(GETDATE(),NULL,@id_salario,@legajo,0)";
                                        command2.Parameters.AddWithValue("@legajo", legajo);
                                        command2.Parameters.AddWithValue("@id_salario", idUltimoSalario);
                                        command2.CommandType = CommandType.Text;
                                        int historialSalarioCreado = command2.ExecuteNonQuery();
                                        if (historialSalarioCreado == 1)
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
            }
            catch (Exception ex)
            {
                return 0;
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
        public string[] ReadSingleRow(IDataRecord dataRecord)
        {
            string[] atributosColaborador = new string[7];

            for (int i = 0; i < 7; i++)
            {
                atributosColaborador[i] = "" + dataRecord[i] + "";
            }


            return atributosColaborador;
        }
        public DataTable getAllSalarios(int legajo,string nombre,string apellido,float monto,int cargo)
        {
            string cadenaFiltros = "";
            if(cargo != 0)
            {
                cadenaFiltros = "AND HC.id_cargo = " + cargo;
            }
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT C.legajo,C.nombre,C.apellido ,CONVERT(varchar,H.fechaInicio,103) as 'fechaInicio',S.monto FROM Salario S JOIN HistorialSalario H ON S.id_salario = H.id_salario JOIN Colaborador C ON c.legajo = H.legajoColaborador JOIN HistorialCargo HC ON HC.legajoColaborador = C.legajo WHERE S.borradoLogico = 0 AND H.borradoLogico = 0 AND C.borradoLogico = 0 AND H.fechaFin IS NULL AND C.legajo LIKE @legajo AND C.nombre LIKE @nombre AND C.apellido LIKE @apellido AND S.monto > @monto " + cadenaFiltros + " ORDER BY S.monto DESC";
                    command.Parameters.AddWithValue("@legajo", legajo + "%");
                    command.Parameters.AddWithValue("@nombre", nombre + "%");
                    command.Parameters.AddWithValue("@apellido", apellido + "%");
                    command.Parameters.AddWithValue("@monto", monto);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }

        }
        public string modificarSalariosTotalidadCargo(int idCargo,float monto)
        {
            int cantidadDePersonasCargo = 0;
            int salarioCreado = 0;
            int historialesDadosDeBaja = 0;
            int salariosInsertados = 0;
            DataTable legajosColaboradoresAfectados = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    /*Aca buscamos la cantidad de personas que hay en el cargo*/
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT COUNT(HC.legajoColaborador) FROM HistorialCargo HC JOIN Cargo C ON HC.id_cargo = C.id_cargo WHERE HC.fechaFin IS NULL AND HC.borradoLogico = 0 AND C.borradoLogico = 0 AND C.id_cargo = @idCargo";
                        command.Parameters.AddWithValue("@idCargo", idCargo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord legajo = (IDataRecord)reader;
                                cantidadDePersonasCargo = int.Parse("" + legajo[0] + "");
                            }
                            reader.Close();

                        }
                        else
                        {
                            return "Error con la base de datos";
                        }

                    }
                    if(cantidadDePersonasCargo == 0)
                    {
                        return "No hay ninguna persona en este cargo";
                    }
                    /*Aca hacemos el insert del nuevo salario para todos los colaboradores de ese cargo*/
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "INSERT INTO Salario VALUES (@monto,0)";
                        command.Parameters.AddWithValue("@monto", monto);
                        command.CommandType = CommandType.Text;
                        salarioCreado = command.ExecuteNonQuery();
                        if (salarioCreado != 1)
                        {
                            return "Error al insertar el monto del salario, porfavor verifique ese campo.";
                        }
                    }
                    int idUltimoSalario = int.Parse(BuscarIdUltimoSalario());

                    /*Aca damos de baja todos los historiales de salario que tenian fecha Fin en NULL para los colaboradores que son de ese cargo*/
                    using (var command = new SqlCommand())
                    {

                        command.Connection = connection;
                        command.CommandText = "UPDATE HistorialSalario  SET fechaFin = GETDATE() WHERE fechaFin IS NULL AND legajoColaborador IN (SELECT HC.legajoColaborador FROM HistorialCargo HC JOIN Cargo C ON HC.id_cargo = C.id_cargo WHERE HC.fechaFin IS NULL AND HC.borradoLogico = 0 AND C.borradoLogico = 0 AND C.id_cargo = @idCargo)";
                        command.Parameters.AddWithValue("@idCargo", idCargo);
                        command.CommandType = CommandType.Text;
                        historialesDadosDeBaja = command.ExecuteNonQuery();
                        if (historialesDadosDeBaja != cantidadDePersonasCargo)
                        {
                            return "Error al dar de baja los salarios antiguos.";
                        }
                    }

                    /*Aca hacemos el insert de los nuevos historiales de Salario*/
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT DISTINCT HC.legajoColaborador AS 'Legajo' FROM HistorialCargo HC JOIN Cargo C ON HC.id_cargo = C.id_cargo JOIN HistorialSalario HS ON HS.legajoColaborador = HC.legajoColaborador WHERE HC.fechaFin IS NULL AND HC.borradoLogico = 0 AND C.borradoLogico = 0 AND C.id_cargo = @idCargo AND HS.legajoColaborador NOT IN (SELECT DISTINCT legajoColaborador FROM HistorialSalario WHERE fechaFin IS NULL)";
                        command.Parameters.AddWithValue("@idCargo", idCargo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            legajosColaboradoresAfectados.Load(reader);
                            foreach (DataRow row in legajosColaboradoresAfectados.Rows)
                            {
                                int legajoColaborador = int.Parse(row["Legajo"].ToString());
                                using (var command2 = new SqlCommand())
                                {
                                    
                                    command2.Connection = connection;
                                    command2.CommandText = "INSERT INTO HistorialSalario VALUES(GETDATE(),NULL,@id_salario,@legajo,0)";
                                    command2.Parameters.AddWithValue("@legajo", legajoColaborador);
                                    command2.Parameters.AddWithValue("@id_salario", idUltimoSalario);
                                    command2.CommandType = CommandType.Text;
                                    int historialSalarioCreado = command2.ExecuteNonQuery();
                                    if (historialSalarioCreado != 1)
                                    {
                                        return "Error al insertar el nuevo salario a uno de los colaboradores";
                                    }
                                    salariosInsertados++;
                                    
                                }

                            }
                            if(salariosInsertados == cantidadDePersonasCargo)
                            {
                                return "Salarios modificados con exito";
                            }
                            else
                            {
                                return "Error al modificar los salarios del cargo";
                            }
                        }
                        else
                        {
                            return "Error con la base de datos";
                        }

                    }



                }


            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public string modificarSalariosCargoPorcentaje(int idCargo,float porcentaje)
        {
            int cantidadDePersonasCargo = 0;
            int salariosInsertados = 0;
            DataTable legajosColaboradoresAfectados = new DataTable();
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    /*Aca buscamos la cantidad de personas que hay en el cargo*/
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT COUNT(HC.legajoColaborador) FROM HistorialCargo HC JOIN Cargo C ON HC.id_cargo = C.id_cargo WHERE HC.fechaFin IS NULL AND HC.borradoLogico = 0 AND C.borradoLogico = 0 AND C.id_cargo = @idCargo";
                        command.Parameters.AddWithValue("@idCargo", idCargo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                IDataRecord legajo = (IDataRecord)reader;
                                cantidadDePersonasCargo = int.Parse("" + legajo[0] + "");
                            }
                            reader.Close();

                        }
                        else
                        {
                            return "Error con la base de datos";
                        }

                    }
                    if (cantidadDePersonasCargo == 0)
                    {
                        return "No hay ninguna persona en este cargo";
                    }
                    


                    /*Aca hacemos la cuenta del porcentaje y modificamos los salarios*/
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "SELECT DISTINCT HC.legajoColaborador AS 'Legajo',S.monto AS 'Monto' FROM HistorialCargo HC JOIN Cargo C ON HC.id_cargo = C.id_cargo JOIN HistorialSalario HS ON HS.legajoColaborador = HC.legajoColaborador JOIN Salario S ON S.id_salario = HS.id_salario WHERE HS.fechaFin IS NULL AND HC.borradoLogico = 0 AND C.borradoLogico = 0 AND C.id_cargo = @idCargo";
                        command.Parameters.AddWithValue("@idCargo", idCargo);
                        command.CommandType = CommandType.Text;
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            legajosColaboradoresAfectados.Load(reader);
                            reader.Close();
                        }
                        else
                        {
                            return "Error con la base de datos";
                        }
                        /*Aca damos de baja todos los historiales de salario que tenian fecha Fin en NULL para los colaboradores que son de ese cargo*/
                        using (var command9 = new SqlCommand())
                        {

                            command9.Connection = connection;
                            command9.CommandText = "UPDATE HistorialSalario  SET fechaFin = GETDATE() WHERE fechaFin IS NULL AND legajoColaborador IN (SELECT HC.legajoColaborador FROM HistorialCargo HC JOIN Cargo C ON HC.id_cargo = C.id_cargo WHERE HC.fechaFin IS NULL AND HC.borradoLogico = 0 AND C.borradoLogico = 0 AND C.id_cargo = @idCargo)";
                            command9.Parameters.AddWithValue("@idCargo", idCargo);
                            command9.CommandType = CommandType.Text;
                            int historialesDadosDeBaja = command9.ExecuteNonQuery();
                            if (historialesDadosDeBaja != cantidadDePersonasCargo)
                            {
                                return "Error al dar de baja los salarios antiguos.";
                            }
                        }
                        foreach (DataRow row in legajosColaboradoresAfectados.Rows)
                            {
                                int legajoColaborador = int.Parse(row["Legajo"].ToString());
                                float salarioBase = float.Parse(row["Monto"].ToString());
                                float porcentajeSalario = porcentaje * salarioBase / 100;
                                float salarioFinal = salarioBase + porcentajeSalario;
                                using (var command1 = new SqlCommand())
                                {

                                    command1.Connection = connection;
                                    command1.CommandText = "INSERT INTO Salario VALUES (@monto,0)";
                                    command1.Parameters.AddWithValue("@monto", salarioFinal);
                                    command1.CommandType = CommandType.Text;
                                    int salarioCreado = command1.ExecuteNonQuery();
                                    if (salarioCreado != 1)
                                    {
                                        return "Error al insertar el monto del salario, porfavor verifique ese campo.";
                                    }
                                }
                                int idUltimoSalario = int.Parse(BuscarIdUltimoSalario());

                                using (var command2 = new SqlCommand())
                                {

                                    command2.Connection = connection;
                                    command2.CommandText = "INSERT INTO HistorialSalario VALUES(GETDATE(),NULL,@id_salario,@legajo,0)";
                                    command2.Parameters.AddWithValue("@legajo", legajoColaborador);
                                    command2.Parameters.AddWithValue("@id_salario", idUltimoSalario);
                                    command2.CommandType = CommandType.Text;
                                    int historialSalarioCreado = command2.ExecuteNonQuery();
                                    if (historialSalarioCreado != 1)
                                    {
                                        return "Error al insertar el nuevo salario a uno de los colaboradores";
                                    }
                                    salariosInsertados++;

                                }

                            }
                            if (salariosInsertados == cantidadDePersonasCargo)
                            {
                                return "Salarios modificados con exito";
                            }
                            else
                            {
                                return "Error al modificar los salarios del cargo";
                            }
                        

                    }



                }




                }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        public DataTable getAllSalariosPorCargo(int idCargo)
        {
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT C.legajo ,CONVERT(varchar,H.fechaInicio,103) as 'fechaInicio',S.monto FROM Salario S JOIN HistorialSalario H ON S.id_salario = H.id_salario JOIN Colaborador C ON c.legajo = H.legajoColaborador JOIN HistorialCargo HC ON HC.legajoColaborador = C.legajo JOIN Cargo CC ON CC.id_cargo = HC.id_cargo WHERE S.borradoLogico = 0 AND H.borradoLogico = 0 AND C.borradoLogico = 0 AND H.fechaFin IS NULL AND HC.fechaFin IS NULL AND CC.id_cargo = @idCargo ORDER BY S.monto DESC";
                    command.Parameters.AddWithValue("@idCargo", idCargo);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }

        }





    }
}
