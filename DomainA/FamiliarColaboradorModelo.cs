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
        public int indiceFamiliar = -1;
        public int idFamiliar = -1;
        public int idDireccion = -1;

        public string InsertarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia, int tipoFamiliar, int colaborador, string nombre, string apellido, DateTime fechaNacimiento, int dni, int escolaridad, string obraSocial, int esTrabajador, int esDependencia, float aportes)
        {
            return familiar.InsertarFamiliarColaborador(calle,numeroCalle,esEdificio,piso,departamento,localidad,provincia,tipoFamiliar,colaborador,nombre,apellido,fechaNacimiento,dni, escolaridad,obraSocial,esTrabajador,esDependencia,aportes);  
        }

        public string ModificarFamiliarColaborador(string calle, int numeroCalle, int esEdificio, int piso, string departamento, string localidad, string provincia, int direccionFamiliar, int tipoFamiliar, int colaborador, string nombre, string apellido, DateTime fechaNacimiento, int dni, int escolaridad, int idFamiliar, string obraSocial, int esTrabajador, int esDependencia, float aportes)
        {
            return familiar.ModificarFamiliarColaborador(calle, numeroCalle, esEdificio, piso, departamento, localidad, provincia, direccionFamiliar, tipoFamiliar,colaborador,nombre,apellido,fechaNacimiento,dni,escolaridad,idFamiliar,obraSocial,esTrabajador,esDependencia,aportes );
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
