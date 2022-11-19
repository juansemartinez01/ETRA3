using Common.Cache;
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
            if (UserCache.perfil == Perfiles.admin){return cuentaColaborador.crearCuentaColaborador(legajo, monto); }
            return "No tiene permisos";
        }

        public DataTable buscarCuentaColaborador(int legajo)
        {
            
            return cuentaColaborador.BuscarCuentaColaborador(legajo);
        }
        public string modificarSaldo(int legajo, float saldo,int tipoMovimiento)
        {
            if (UserCache.perfil == Perfiles.admin) { return cuentaColaborador.modificarSaldo(legajo, saldo, tipoMovimiento); }
            return "No tiene permisos";
        }
        public float buscarSaldo(int legajo)
        {
            return cuentaColaborador.buscarSaldo(legajo);
        }
        public int eliminarMovimiento(int legajo, int idMovimiento)
        {
            if (UserCache.perfil == Perfiles.admin) {return cuentaColaborador.eliminarMovimiento(legajo, idMovimiento); }
            return -1;
        }
        public string buscarFondoMaximoPermitido(int legajo)
        {
            return cuentaColaborador.buscarFondoMaximoPermitido(legajo);
        }
    }
}
