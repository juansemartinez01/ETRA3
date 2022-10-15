using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainA;


namespace PresentationA.Colaboradores
{
    public partial class frmAvisos : frmHijo
    {
        NotifiacacionesGeneralesModelo notificacion = new NotifiacacionesGeneralesModelo();
        public frmAvisos()
        {
            InitializeComponent();
            cargarGrillaCumpleaños();
        }
        public void cargarGrillaCumpleaños()
        {
            DataTable cumpleañosColaboradores = new DataTable();
            try
            {
                dgvCumpleañosDelMes.Rows.Clear();
                cumpleañosColaboradores = notificacion.notificacionesDeCumpleaños();
                for (int i = 0; i < cumpleañosColaboradores.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvCumpleañosDelMes.Rows.Add(cumpleañosColaboradores.Rows[i]["Nombre"], cumpleañosColaboradores.Rows[i]["Apellido"], cumpleañosColaboradores.Rows[i]["Cumpleaños"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
