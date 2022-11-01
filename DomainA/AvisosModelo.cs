using DataAccesA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class AvisosModelo
    {
        AvisosDao AvisosDao = new AvisosDao();


        public string crearAviso(int idTipoAviso, string descripcion, DateTime fechaCarga, DateTime fechaOcurrencia, DateTime fechaNotificacion, int[] legajosNotificados)
        {
            string mensajeErrorInsercion = "";
            mensajeErrorInsercion = AvisosDao.insertarAviso(idTipoAviso, descripcion, fechaCarga, fechaOcurrencia, fechaNotificacion);
            if(mensajeErrorInsercion != "Insercion del aviso exitosa")
            {
                return mensajeErrorInsercion;
            }
            int idAviso = int.Parse(AvisosDao.buscarIdUltimoAviso());
            mensajeErrorInsercion = AvisosDao.declararNotificados(idAviso, legajosNotificados);
            if (mensajeErrorInsercion != "Insercion de los notificados exitosa")
            {
                return mensajeErrorInsercion;
            }
            return "Aviso creado con exito";
        }
    }
}
