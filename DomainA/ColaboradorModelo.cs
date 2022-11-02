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


        public string CrearColaborador(string nombre, string apellido, int dni, string cuit, string calle, int numeroCalle, int puesto, int piso, string departamento, string localidad, string provincia, int estado,float salario,string mail,string telefonoContacto,string telefonoEmergencia,DateTime fechaNacimiento,DateTime fechaIngreso,string obraSocial,int legajoResponsable)
        {
            var creadoExito = colaboradorDao.CrearColaborador(nombre, apellido, dni, cuit, calle, numeroCalle, puesto, piso, departamento, localidad, provincia, estado,salario,mail,telefonoContacto,telefonoEmergencia,fechaNacimiento,fechaIngreso,obraSocial,legajoResponsable);
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
            return colaboradorDao.EliminarColaboradorPermanentemente();
            
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
        public string modificarColaborador(int legajo, string nombre, string apellido, DateTime fechaNacimiento, string Cuit, int dni, string calle, int numeroCalle, int piso, string depto, string localidad, string mail, string telefonoContacto, string telefonoEmergencia, int estado, string obraSocial, int puesto, int legajoResponsable)
        {
            return colaboradorDao.modificarColaborador(legajo,nombre,apellido,fechaNacimiento,Cuit,dni,calle,numeroCalle,piso,depto,localidad,mail,telefonoContacto,telefonoEmergencia,estado,obraSocial,puesto,legajoResponsable); 
        }
        public DataTable buscarLegajosDeUnCargo(int idCargo)
        {
            return colaboradorDao.buscarLegajosDeUnCargo(idCargo);
        }
    }
}
