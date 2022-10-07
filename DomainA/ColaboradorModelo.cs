using System;
using System.Data;
using DataAccesA;


namespace DomainA
{
    public class ColaboradorModelo
    {
        ColaboradorDao colaboradorDao = new ColaboradorDao();
        public int legajo;

        public string BuscarLegajoUltimoColaborador()
        {
            return colaboradorDao.BuscarLegajoUltimoColaborador();
        }
        public DataTable BuscarColaborador(string legajo, string nombre, string apellido)
        {
            return colaboradorDao.BuscarColaborador(legajo, nombre, apellido);
        }


        public string CrearColaborador(string nombre, string apellido, int dni, string cuit, string calle, int numeroCalle, int puesto, int piso, string departamento, string localidad, string provincia, int estado)
        {
            var creadoExito = colaboradorDao.CrearColaborador(nombre, apellido, dni, cuit, calle, numeroCalle, puesto, piso, departamento, localidad, provincia, estado);
            if (creadoExito == 1)
            {
                return "El colaborador fue creado con exito";
            }
            else
            {
                return "El colaborador no pudo ser creado";
            }

        }

        public string EliminarColaboradorPermanentemente()
        {
            int correctaEliminacion = colaboradorDao.EliminarColaboradorPermanentemente();
            if (correctaEliminacion == 1)
            {
                return "Colaborador eliminado correctamente";
            }
            else
            {
                return "Error";
            }
        }

        public string EliminarColaborador(int legajo)
        {
            int colaboradorEliminado = colaboradorDao.EliminarColaborador(legajo);
            if (colaboradorEliminado == 1)
            {
                return "Colaborador eliminado correctamente";
            }
            else
            {
                return "No se pudo eliminar al colaborador";
            }
        }
        public int BuscarIdUltimoEvento()
        {
            return int.Parse(colaboradorDao.BuscarIdUltimoEvento());
        }

    }
}
