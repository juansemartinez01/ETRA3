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

        public DataTable obtenerSalarios(string legajo)
        {
            return salariosDao.obtenerSalarios(legajo);
        }
        public string modificarSalarioColaborador(int legajo, float monto)
        {
            int correcto = salariosDao.modificarSalarioColaborador(legajo,monto);
            if(correcto == 0)
            {
                return "Ocurrio un error";
            }
            else
            {
                return "Salario actualizado con exito";
            }

        }
    }
    
}
