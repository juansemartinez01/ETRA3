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
        public string InsertarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia,int tipoFamiliar,int colaborador,string nombre,string apellido,DateTime fechaNacimiento,int dni,int escolaridad,string obraSocial,int esTrabajador,int esDependencia, float aportes)
        {
            int direccionCreada = InsertarDireccionFamiliar(calle,numeroCalle,esEdificio,piso,departamento,localidad,provincia);
            if (direccionCreada == 0) { return "Error al crear al familiar"; }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "INSERT INTO FamiliarColaborador VALUES (@tipoFamiliar,@colaborador,@nombre,@apellido,Format(@fechaNacimiento, 'yyyy - MM - dd'),0,@dni,(SELECT MAX(id_direccion) FROM Direccion),@escolaridad,@obraSocial,@esTrabajador,@esDependencia,@aportes)";
                    command.Parameters.AddWithValue("@tipoFamiliar", tipoFamiliar);
                    command.Parameters.AddWithValue("@colaborador", colaborador);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@escolaridad", escolaridad);
                    command.Parameters.AddWithValue("@obraSocial", obraSocial);
                    command.Parameters.AddWithValue("@esTrabajador", esTrabajador);
                    command.Parameters.AddWithValue("@esDependencia", esDependencia);
                    command.Parameters.AddWithValue("@aportes", aportes);
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
                    command.CommandText = "UPDATE Direccion SET nombreCalle = @nombreCalle,numeroCalle = @numeroCalle,esEdificio = @esEdificio,piso = @piso,departamento = @departamento,localidad = @localidad,provincia = @provincia WHERE id_direccion = @direccionFamiliar";
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

        public string ModificarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia,int direccionFamiliar, int tipoFamiliar, int colaborador, string nombre, string apellido, DateTime fechaNacimiento, int dni, int escolaridad,int idFamiliar, string obraSocial, int esTrabajador, int esDependencia, float aportes)
        {
            
            int direccionCreada = ModificarDireccionFamiliar(calle, numeroCalle, esEdificio, piso, departamento, localidad, provincia, direccionFamiliar);
            if (direccionCreada == 0) { return "Error al modificar al familiar"; }
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE FamiliarColaborador SET tipoFamiliar = @tipoFamiliar,nombreFamiliar = @nombre,apellidoFamiliar = @apellido,fechaNacimiento = Format(@fechaNacimiento, 'yyyy - MM - dd'),dni = @dni,escolaridad = @escolaridad,obraSocial = @obraSocial,trabaja = @esTrabajador,dependencia = @esDependencia,aportes = @aportes WHERE idFamiliar = @idFamiliar";
                    command.Parameters.AddWithValue("@tipoFamiliar", tipoFamiliar);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@escolaridad", escolaridad);
                    command.Parameters.AddWithValue("@idFamiliar", idFamiliar);
                    command.Parameters.AddWithValue("@obraSocial", obraSocial);
                    command.Parameters.AddWithValue("@esTrabajador", esTrabajador);
                    command.Parameters.AddWithValue("@esDependencia", esDependencia);
                    command.Parameters.AddWithValue("@aportes", aportes);
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
        

        

        public string EliminarFamiliarColaborador(int idFamiliar)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "UPDATE FamiliarColaborador SET borradoLogico = 1 WHERE idFamiliar = @idFamiliar";
                    
                    command.Parameters.AddWithValue("@idFamiliar", idFamiliar);
                    command.CommandType = CommandType.Text;
                    var familiarAgregado = command.EndExecuteNonQuery(command.BeginExecuteNonQuery());
                    if (familiarAgregado == 1)
                    {
                        return "Familiar Eliminado";
                    }
                    else
                    {
                        return "Error al eliminar al familiar";
                    }
                }
            }

        }

        public DataTable obtenerFamiliares(int legajoColaborador)
        {
            string parametros = "";
            if (legajoColaborador != 0)
            {
                parametros += " AND C.legajo = " + legajoColaborador;
            }
            DataTable resultado = new DataTable();
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT FC.idFamiliar AS 'idFamiliar' ,C.legajo,FC.idDireccion AS 'idDireccion',FC.nombreFamiliar AS 'Nombre',FC.apellidoFamiliar AS 'Apellido',E.nombre AS 'Escolarización',FC.dni AS 'DNI',FC.fechaNacimiento AS 'Fecha Nacimiento',C.legajo, TF.nombre as 'Tipo Familiar', D.nombreCalle, d.numeroCalle,d.piso,d.departamento,d.localidad,d.provincia,CASE WHEN FC.trabaja = 0 THEN 'No' WHEN FC.trabaja = 1 then 'Si'end as trabaja,CASE WHEN FC.aportes = 0 THEN 'No' WHEN FC.aportes = 1 then 'Si'end as aportes,FC.obraSocial FROM FamiliarColaborador FC JOIN Colaborador C ON FC.legajoColaborador = C.legajo JOIN TipoFamiliar TF ON TF.idTipoFamiliar = FC.tipoFamiliar JOIN Direccion D ON D.id_direccion = FC.idDireccion JOIN Escolaridad E ON E.id = FC.escolaridad WHERE FC.borradoLogico = 0 " + parametros;
                    
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    resultado.Load(reader);
                    return resultado;
                }
            }
        }
    }
}
