using Common.Cache;
using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class AvisosModelo
    {
        AvisosDao AvisosDao = new AvisosDao();

        public bool notificarAvisosHoy() { return AvisosDao.notificarAvisosHoy(); }

        public DataTable getAllAvisosMesActual() { return AvisosDao.getAllAvisosMesActual(); }
        public DataTable getAllAvisos(int legajo, int idTipoAviso, string fechaOcurrencia, string fechaCarga, string fechaNotificacion,bool filtroFecha) { return AvisosDao.getAllAvisos(legajo, idTipoAviso, fechaOcurrencia,fechaCarga,fechaNotificacion,filtroFecha); }

        public string crearAviso(int idTipoAviso, string descripcion, DateTime fechaOcurrencia, DateTime fechaNotificacion, int[] legajosNotificados)
        {
            if (UserCache.perfil == Perfiles.admin)
            {

                string mensajeErrorInsercion = "";
                mensajeErrorInsercion = AvisosDao.insertarAviso(idTipoAviso, descripcion, fechaOcurrencia, fechaNotificacion);
                if (mensajeErrorInsercion != "Insercion del aviso exitosa")
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
            return "No tiene permisos";
        }

        public bool notificarAviso(int id, string subject, string body) { if (UserCache.perfil == Perfiles.admin) { return AvisosDao.notificarAviso(id, subject, body); } return false; }
    }
}
