using System;
using DataAccess;

namespace Domain
{
    public class ColaboradorModelo
    {
        ColaboradorDao colaboradorDao = new ColaboradorDao();

        public string BuscarLegajoUltimoColaborador()
        {
            return colaboradorDao.BuscarLegajoUltimoColaborador();
        }
        public string[] BuscarColaborador(int legajo,string nombre,string apellido)
        {
            return colaboradorDao.BuscarColaborador(legajo,  nombre,  apellido);
        }
        public string CrearColaborador(string nombre,string apellido, int dni, int cuit, string calle, int numeroCalle)
        {
            var creadoExito = colaboradorDao.CrearColaborador(nombre,apellido,dni,cuit,calle,numeroCalle);
            if(creadoExito == 1)
            {
                return "El colaborador fue creado con exito";
            }
            else
            {
                return "El colaborador no pudo ser creado";
            }

        }
        
    }
}
