using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class FamiliarColaboradorModelo
    {
        FamiliarColaboradorDao familiar = new FamiliarColaboradorDao();

        public string InsertarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia, int tipoFamiliar, int colaborador, string nombre, string apellido, DateTime fechaNacimiento, int dni, int escolaridad)
        {
            return familiar.InsertarFamiliarColaborador(calle,numeroCalle,esEdificio,piso,departamento,localidad,provincia,tipoFamiliar,colaborador,nombre,apellido,fechaNacimiento,dni, escolaridad);  
        }

        public string ModificarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia, int direccionFamiliar, int tipoFamiliar, int colaborador, string nombre, string apellido, DateTime fechaNacimiento, int dni, int escolaridad, int idFamiliar)
        {
            return familiar.ModificarFamiliarColaborador(calle, numeroCalle, esEdificio, piso, departamento, localidad, provincia, direccionFamiliar, tipoFamiliar,colaborador,nombre,apellido,fechaNacimiento,dni,escolaridad,idFamiliar );
        }

        public string EliminarFamiliarColaborador(int idFamiliar)
        {
            return familiar.EliminarFamiliarColaborador(idFamiliar);
        }

        /*Si quiero filtrar por colaboradores mandar un legajo, si quiero todos los familiares mandar 0 en legajoColaborador*/
        public DataTable obtenerFamiliares(int legajoColaborador)
        {
            return familiar.obtenerFamiliares(legajoColaborador);
        }


        }
}
