using System;
using System.Data;
using DataAccesA;


namespace DomainA
{
    
    public class Eventos
    {
        EventosDao eventosDao = new EventosDao();
        public int FilaSeleccionadaHistorialEvento;
        public DataTable obtenerEventos(string legajo)
        {
            return eventosDao.obtenerEventos(legajo);
        }
        public DataTable getAllEventos()
        {
            return eventosDao.getAllEventos();
        }
        public string InsertarEventos(int tipoEvento, int legajoColaborador, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            return eventosDao.InsertarEvento(tipoEvento, legajoColaborador, descripcion, fechaInicio, fechaFin);
        }
        public string buscarUltimoEvento()
        {
            return eventosDao.BuscarIdUltimoEvento();
        }
    }
}
