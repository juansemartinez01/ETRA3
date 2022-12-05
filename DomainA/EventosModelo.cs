using System;
using System.Data;
using Common.Cache;
using DataAccesA;


namespace DomainA
{
    
    public class EventosModelo
    {
        EventosDao eventosDao = new EventosDao();
        public int feriadoSeleccionado = -1;
        public int FilaSeleccionadaHistorialEvento = -1;
        public int mesGeneracionComprobante = -1;
        public int añoGeneracionComprobante = -1;
        public float agregadoSueldo = 0;
        public float restaSueldo = 0;
        public bool primerInicioComprobantes = false;
        public DataTable obtenerEventos(string legajo,bool soloPagosSueldo)
        {
            return eventosDao.obtenerEventos(legajo, soloPagosSueldo);
        }
        public DataTable getAllEventos()
        {
            return eventosDao.getAllEventos();
        }
        public string InsertarEventos(int tipoEvento, int legajoColaborador, string descripcion, DateTime fechaInicio, DateTime fechaFin)
        {
            if (UserCache.perfil == Perfiles.admin) {return eventosDao.InsertarEvento(tipoEvento, legajoColaborador, descripcion, fechaInicio, fechaFin); }
            return "No tiene permisos";
        }
        public string buscarUltimoEvento()
        {
            return eventosDao.BuscarIdUltimoEvento();
        }
        public string eliminarEvento(int idEvento)
        {
            if (UserCache.perfil == Perfiles.admin) { return eventosDao.eliminarEvento(idEvento); }
            return "No tiene permisos";
        }
        public string modificarEvento(int idEvento, int tipoEvento, DateTime fechaInicio, DateTime fechaFin, DateTime fechaRegistro, string descripcion)
        {
            if (UserCache.perfil == Perfiles.admin) { return eventosDao.modificarEvento(idEvento, tipoEvento, fechaInicio, fechaFin, fechaRegistro, descripcion); }
            return "No tiene permisos";
        }
        public int buscarIdConNombre(string nombreBusqueda,string nombreTabla)
        {
            return eventosDao.buscarIdConNombre(nombreBusqueda, nombreTabla);
        }
        public string comprobantesFeriadoYBonos(int legajo, DateTime fecha, float monto, string descripcion,int tipoEvento)
        { 
            return eventosDao.comprobantesFeriadoYBonos(legajo,fecha,monto, descripcion,tipoEvento);
        }
        public float sumaFeriadosYAnticiposADescontar(int legajo, int mes, int tipoEvento1,int tipoEvento2, int año)
        {
            return eventosDao.sumaFeriadosYAnticiposADescontar(legajo,mes,tipoEvento1, tipoEvento2,año);
        }
        public DataTable getAllFeriadosYBonos(int legajo,int mes, int año)
        {
            return eventosDao.getAllFeriadosYBonos(legajo,mes,año);
        }

        }
}
