using DataAccesA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainA
{
    public class NotifiacacionesGeneralesModelo
    {
        NotificacionesGeneralesDao notificacion = new NotificacionesGeneralesDao();

        public string[] notificacionesDeCumpleaños()
        {
            return notificacion.notificacionesDeCumpleaños();
            
        }
    }
}
