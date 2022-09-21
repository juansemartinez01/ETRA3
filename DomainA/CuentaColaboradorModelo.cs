using DataAccesA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public  class CuentaColaboradorModelo
    {
        CuentaColaboradorDao cuentaColaborador = new CuentaColaboradorDao();

        public string crearCuentaColaborador(int legajo,float monto)
        {
            return cuentaColaborador.crearCuentaColaborador(legajo,monto);
        }
    }
}
