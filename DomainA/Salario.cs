using Common.Cache;
using DataAccesA;
using DataAccessA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    
    public class Salario
    {
        SalariosDao salariosDao = new SalariosDao();
        public int legajoColaborador;

        public string modificarSalariosDeCargo(int idCargo,float monto)
        {

            if (UserCache.perfil == Perfiles.admin) { return salariosDao.modificarSalariosTotalidadCargo(idCargo, monto); }
            return "No tiene permisos";
        }
        public DataTable getAllSalariosPorCargo(int idCargo)
        {
            return  salariosDao.getAllSalariosPorCargo(idCargo);
        }
        public string modificarSalariosCargoPorcentaje(int idCargo,float porcentaje)
        {
            if (UserCache.perfil == Perfiles.admin) { return salariosDao.modificarSalariosCargoPorcentaje(idCargo, porcentaje); }
            return "No tiene permisos";
        }

        public DataTable obtenerSalarios(string legajo)
        {
            return salariosDao.obtenerSalarios(legajo);
        }
        public string modificarSalarioColaborador(int legajo, float monto)
        {
            if (UserCache.perfil == Perfiles.admin) {
                int correcto = salariosDao.modificarSalarioColaborador(legajo,monto); 
                if(correcto == 0){return "Ocurrio un error";}
                return "Salario actualizado con exito";
            }
            return "No tiene permisos";
        }
        public DataTable getAllSalarios(int legajo,string nombre,string apellido,float monto,int cargo)
        {
            return salariosDao.getAllSalarios(legajo,nombre,apellido,monto,cargo);
        }
    }
    
}
