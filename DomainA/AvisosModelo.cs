﻿using DataAccesA;
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

        public bool notificarMesActual() { return AvisosDao.notificarMesActual(); }

        public DataTable getAllAvisosMesActual() { return AvisosDao.getAllAvisosMesActual(); }
        public string crearAviso(int idTipoAviso, string descripcion, DateTime fechaOcurrencia, DateTime fechaNotificacion, int[] legajosNotificados)
        {
            string mensajeErrorInsercion = "";
            mensajeErrorInsercion = AvisosDao.insertarAviso(idTipoAviso, descripcion, fechaOcurrencia, fechaNotificacion);
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
