using DataAccesA;
using System;
using System.Data;
using System.Data.SqlClient;

public class VestimentaDao : ConnectionToSql
{
    

    public void InsertarVestimenta(int legajoColaborador, int sucursal, int area, string pantalon, string buzo, string remera, string calzado)
    {

        using (var connection = GetConnection())
        {
            connection.Open();

            string query = "DELETE FROM Vestimenta WHERE legajoColaborador = @legajo";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@legajo", legajoColaborador);

                command.ExecuteNonQuery();
            }
        }

        using (var connection = GetConnection())
        {
            connection.Open();

            string query = "INSERT INTO Vestimenta (legajoColaborador, sucursal, area, pantalon, buzo, remera, calzado) VALUES (@legajo, @sucursal, @area, @pantalon, @buzo, @remera, @calzado)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@legajo", legajoColaborador);
                command.Parameters.AddWithValue("@sucursal", sucursal);
                command.Parameters.AddWithValue("@area", area);
                command.Parameters.AddWithValue("@pantalon", pantalon);
                command.Parameters.AddWithValue("@buzo", buzo);
                command.Parameters.AddWithValue("@remera", remera);
                command.Parameters.AddWithValue("@calzado", calzado);

                command.ExecuteNonQuery();
            }
        }
    }
    public void EliminarVestimenta(int legajoColaborador)
    {
        using (var connection = GetConnection())
        {
            connection.Open();

            string query = "DELETE FROM Vestimenta WHERE legajoColaborador = @legajo";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@legajo", legajoColaborador);

                command.ExecuteNonQuery();
            }
        }
    }

    public DataTable obtenerVestimenta(string legajo)
    {
        string parametros = "";
        if(int.Parse(legajo) != 0)
        {
            parametros = "AND legajoColaborador = " + legajo;
        }
        DataTable resultado = new DataTable();
        using (var connection = GetConnection())
        {
            connection.Open();
            using (var command = new SqlCommand())
            {
                command.Connection = connection;
                command.CommandText = "SELECT V.legajoColaborador as 'Legajo',s.nombre as 'Sucursal',a.nombre as 'Area',V.pantalon as 'Pantalon',V.buzo as 'Buzo',V.remera as 'Remera',V.calzado as 'Calzado' FROM Vestimenta V JOIN Colaborador C ON C.legajo = V.legajoColaborador JOIN Sucursal s on s.codigoSucursal = V.sucursal JOIN Area a on a.idArea = V.area WHERE C.borradoLogico = 0 " + parametros;
                command.Parameters.AddWithValue("@legajo", legajo);
                command.CommandType = CommandType.Text;
                SqlDataReader reader = command.ExecuteReader();
                resultado.Load(reader);
                return resultado;
            }
        }
    }
    public void ModificarVestimenta(int legajoColaborador, int sucursal, int area, string pantalon, string buzo, string remera, string calzado)
    {
        using (var connection = GetConnection())
        {
            connection.Open();

            string query = "UPDATE Vestimenta SET sucursal = @sucursal, area = @area, pantalon = @pantalon, buzo = @buzo, remera = @remera, calzado = @calzado WHERE legajoColaborador = @legajo";

            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@sucursal", sucursal);
                command.Parameters.AddWithValue("@area", area);
                command.Parameters.AddWithValue("@pantalon", pantalon);
                command.Parameters.AddWithValue("@buzo", buzo);
                command.Parameters.AddWithValue("@remera", remera);
                command.Parameters.AddWithValue("@calzado", calzado);
                command.Parameters.AddWithValue("@legajo", legajoColaborador);

                command.ExecuteNonQuery();
            }
        }
    }
}