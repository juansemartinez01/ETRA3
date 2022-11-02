using DomainA;
using System;
using System.Data;

namespace PresentationA
{
    public partial class frmInicio : frmHijo
    {
        public frmInicio()
        {
            InitializeComponent();
            
        }

        private void cargarTabla()
        {
            try
            {
                dgvAvisos.Rows.Clear();
                DataTable avisos = new DataTable();
                avisos = new AvisosModelo().getAllAvisosMesActual();
                for (int i = 0; i < avisos.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvAvisos.Rows.Add(avisos.Rows[i]["Tipo de Aviso"], avisos.Rows[i]["Legajo"], avisos.Rows[i]["Descripcion"], avisos.Rows[i]["Fecha de Ocurrencia"], avisos.Rows[i]["Fecha de Carga"], avisos.Rows[i]["Fecha de Notificación"]);
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void fechaActual_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }
    }
}
