using System;
using System.Data.SqlClient;
using System.Data;
using System.Net;

namespace DataAccesA
{
    public class FamiliarColaboradorDao:ConnectionToSql
    {
        public int InsertarDireccionFamiliar(string calle,int numeroCalle,int esEdificio,int piso,string departamento,string localidad,string provincia)
        {
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
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                    }
            }
        }
        public string InsertarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia,int tipoFamiliar,int colaborador,string nombre,string apellido,DateTime fechaNacimiento,int dni,int escolaridad)
        {
            int direccionCreada = InsertarDireccionFamiliar(calle,numeroCalle,esEdificio,piso,departamento,localidad,provincia);
            if (direccionCreada == 0) { return "Error al crear al familiar"; }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO FamiliarColaborador VALUES (@tipoFamiliar,@colaborador,@nombre,@apellido,Format(@fechaNacimiento, 'yyyy - MM - dd'),0,@dni,(SELECT MAX(id_direccion) FROM Direccion),@escolaridad)";
                    command.Parameters.AddWithValue("@tipoFamiliar", tipoFamiliar);
                    command.Parameters.AddWithValue("@colaborador", colaborador);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@escolaridad", escolaridad);
                    command.CommandType = CommandType.Text;
                    var familiarAgregado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (familiarAgregado == 1)
                    {
                        return "Familiar creado";
                    }
                    else
                    {
                        return "Error al agregar al familiar";
                    }
                }
            }

        }


        public int ModificarDireccionFamiliar(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia,int direccionFamiliar)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE Direccion SET UPDATE Direccion SET nombreCalle = @nombreCalle,numeroCalle = @numeroCalle,esEdificio = @esEdificio,piso = @piso,departamento = @departamento,localidad = @localidad,provincia = @provincia WHERE id_direccion = @direccionFamiliar";
                    command.Parameters.AddWithValue("@nombreCalle", calle);
                    command.Parameters.AddWithValue("@numeroCalle", numeroCalle);
                    command.Parameters.AddWithValue("@esEdificio", esEdificio);
                    command.Parameters.AddWithValue("@piso", piso);
                    command.Parameters.AddWithValue("@departamento", departamento);
                    command.Parameters.AddWithValue("@localidad", localidad);
                    command.Parameters.AddWithValue("@provincia", provincia);
                    command.Parameters.AddWithValue("@direccionFamiliar", direccionFamiliar);
                    command.CommandType = CommandType.Text;
                    var direccionCreada = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (direccionCreada == 1)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        public string ModificarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia,int direccionFamiliar, int tipoFamiliar, int colaborador, string nombre, string apellido, DateTime fechaNacimiento, int dni, int escolaridad,int idFamiliar)
        {
            int direccionCreada = ModificarDireccionFamiliar(calle, numeroCalle, esEdificio, piso, departamento, localidad, provincia, direccionFamiliar);
            if (direccionCreada == 0) { return "Error al modificar al familiar"; }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE FamiliarColaborador SET tipoFamiliar = @tipoFamiliar,nombreFamiliar = @nombre,apellidoFamiliar = @apellido,fechaNacimiento = Format(@fechaNacimiento, 'yyyy - MM - dd'),dni = @dni,escolaridad = @escolaridad";
                    command.Parameters.AddWithValue("@tipoFamiliar", tipoFamiliar);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@escolaridad", escolaridad);
                    command.CommandType = CommandType.Text;
                    var familiarAgregado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (familiarAgregado == 1)
                    {
                        return "Familiar Modificado";
                    }
                    else
                    {
                        return "Error al modificar al familiar";
                    }
                }
            }

        }
    }
}
