using DataAccesA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class FamiliarColaboradorModelo
    {
        FamiliarColaboradorDao familiar = new FamiliarColaboradorDao();

        public string crearFamiliarColaborador(int tipoFamiliar, int legajoColaborador, string nombreFamiliar,string apellidoFamiliar, DateTime fechaNacimiento)
        {
            return familiar.crearFamiliarColaborador(tipoFamiliar,legajoColaborador,nombreFamiliar, apellidoFamiliar, fechaNacimiento);
        }
    }
}
