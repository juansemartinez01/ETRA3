using DomainA;
using System;
using System.Data;
using System.Windows;

namespace PresentationA
{
    public partial class frmInicio : frmHijo
    {
        AvisosModelo avisosModelo = new AvisosModelo();
        public frmInicio()
        {
            InitializeComponent();
            cargarAvisos();
        }

        
        public void cargarAvisos()
        {
            //Tenemos que traer la tabla segun los valores ingresados en el filtro, en un principio solo traemos todos los avisos
            DataTable avisos = avisosModelo.getAllAvisosMesActual();
            
            try
            {
                dgvAvisos.Rows.Clear();
                
                for (int i = 0; i < avisos.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvAvisos.Rows.Add(avisos.Rows[i]["nombre"], avisos.Rows[i]["legajo"], avisos.Rows[i]["fechaOcurrencia"], avisos.Rows[i]["descripcion"], avisos.Rows[i]["fechaCarga"], avisos.Rows[i]["fechaNotificacion"]);
                }
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void fechaActual_Tick(object sender, EventArgs e)
        {
            lblFechaActual.Text = DateTime.Now.ToLongDateString();
        }
    }
}
