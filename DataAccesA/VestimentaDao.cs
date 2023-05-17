using DataAccesA;
using System;
using System.Data.SqlClient;

public class VestimentaDao : ConnectionToSql
{
    

    public void InsertarVestimenta(int legajoColaborador, int sucursal, int area, int pantalon, string buzo, string remera, string calzado)
    {
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
    public void ModificarVestimenta(int legajoColaborador, int sucursal, int area, int pantalon, string buzo, string remera, string calzado)
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