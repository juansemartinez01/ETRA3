using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class VestimentaModelo
    {
        VestimentaDao vestimentaDao = new VestimentaDao();
        public int legajoColaborador;
        public int sucursal;
        public int area;
        public int pantalon;
        public string buzo;
        public string remera;
        public string calzado;

        public void EliminarVestimenta(int legajoColaborador)
        {
            vestimentaDao.EliminarVestimenta(legajoColaborador);
        }
        public void InsertarVestimenta(int legajoColaborador, int sucursal, int area, int pantalon, string buzo, string remera, string calzado)
        {
            vestimentaDao.InsertarVestimenta(legajoColaborador,sucursal,area,pantalon,buzo, remera, calzado);
        }
        public void ModificarVestimenta(int legajoColaborador, int sucursal, int area, int pantalon, string buzo, string remera, string calzado)
        {
            vestimentaDao.ModificarVestimenta(legajoColaborador, sucursal, area, pantalon, buzo, remera, calzado);
        }

    }

}
