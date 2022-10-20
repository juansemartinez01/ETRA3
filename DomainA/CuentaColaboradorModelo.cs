using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    
    public  class CuentaColaboradorModelo
    {
        CuentaColaboradorDao cuentaColaborador = new CuentaColaboradorDao();
        public int Movimientoid { get; set; }
        public int TipoMovimineto { get; set; }

        public string crearCuentaColaborador(int legajo,double monto)
        {
            return cuentaColaborador.crearCuentaColaborador(legajo,monto);
        }

        public DataTable buscarCuentaColaborador(int legajo)
        {
            return cuentaColaborador.BuscarCuentaColaborador(legajo);
        }
        public string modificarSaldo(int legajo, float saldo,int tipoMovimiento)
        {
            return cuentaColaborador.modificarSaldo(legajo, saldo, tipoMovimiento);
        }
        public float buscarSaldo(int legajo)
        {
            return cuentaColaborador.buscarSaldo(legajo);
        }
        public int eliminarMovimiento(int legajo, int idMovimiento)
        {
            return cuentaColaborador.eliminarMovimiento(legajo, idMovimiento);
        }
        public string buscarFondoMaximoPermitido(int legajo)
        {
            return cuentaColaborador.buscarFondoMaximoPermitido(legajo);
        }
    }
}
