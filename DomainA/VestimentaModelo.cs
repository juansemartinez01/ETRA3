using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class VestimentaModelo
    {
        VestimentaDao vestimentaDao = new VestimentaDao();
        public int legajoColaborador;
        public Nullable<int> sucursal;
        public string nombreSucursal;
        public Nullable<int> area;
        public string nombreArea;
        public Nullable<int> pantalon;
        public string buzo;
        public string remera;
        public Nullable<int> calzado;
        public int filaSeleccionada = 0;

        

        public void EliminarVestimenta(int legajoColaborador)
        {
            vestimentaDao.EliminarVestimenta(legajoColaborador);
        }
        public void InsertarVestimenta(int legajoColaborador, int sucursal, int area, string pantalon, string buzo, string remera, string calzado)
        {
            vestimentaDao.InsertarVestimenta(legajoColaborador, sucursal, area, pantalon, buzo, remera, calzado);
        }
        public void ModificarVestimenta(int legajoColaborador, int sucursal, int area, string pantalon, string buzo, string remera, string calzado)
        {
            vestimentaDao.ModificarVestimenta(legajoColaborador, sucursal, area, pantalon, buzo, remera, calzado);
        }
        public DataTable obtenerVestimenta(string legajo)
        {
            return vestimentaDao.obtenerVestimenta(legajo);
        }

    }
}
