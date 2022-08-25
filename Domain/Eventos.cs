using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DataAccess;

namespace Domain
{
    public class Eventos
    {
        EventosDao eventosDao = new EventosDao();
        public DataTable obtenerEventos(string legajo)
        {
            return eventosDao.obtenerEventos(legajo);
        }
        public DataTable getAllEventos()
        {
            return eventosDao.getAllEventos();
        }
        public string InsertarEventos(int tipoEvento,int legajoColaborador,string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            return eventosDao.InsertarEvento(tipoEvento,legajoColaborador,descripcion,fechaInicio, fechaFin);
        }
    }
}
