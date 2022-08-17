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
    }
}
