using System;
using System.Data;
using DataAccesA;


namespace DomainA
{
    
    public class Eventos
    {
        EventosDao eventosDao = new EventosDao();
        public int FilaSeleccionadaHistorialEvento = -1;
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
        public string eliminarEvento(int idEvento)
        {
            return eventosDao.eliminarEvento(idEvento);
        }
        public string modificarEvento(int idEvento, int tipoEvento, DateTime fechaInicio, DateTime fechaFin, DateTime fechaRegistro, string descripcion)
        {
            return eventosDao.modificarEvento(idEvento, tipoEvento, fechaInicio, fechaFin, fechaRegistro, descripcion);
        }
        public int buscarIdConNombre(string nombreBusqueda,string nombreTabla)
        {
            return eventosDao.buscarIdConNombre(nombreBusqueda, nombreTabla);
        }
    }
}
