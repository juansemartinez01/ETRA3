using DataAccesA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class NotifiacacionesGeneralesModelo
    {
        NotificacionesGeneralesDao notificacion = new NotificacionesGeneralesDao();

        public DataTable notificacionesDeCumpleaños()
        {
            return notificacion.notificacionesDeCumpleañosColaboradores();
            
        }
        public DataTable cumpleañosFamiliaresColaboradores()
        {
            return notificacion.cumpleañosFamiliaresColaboradores();
        }
    }
}
