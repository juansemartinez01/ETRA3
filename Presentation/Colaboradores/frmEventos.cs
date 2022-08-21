using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Presentation.Colaboradores
{
    public partial class frmEventos : frmHijo
    {
        Eventos obje = new Eventos();
        DataTable eventos;
        public frmEventos()
        {
            InitializeComponent();
            CargarDG();
        }
        private void CargarDG()
        {
            try
            {
                eventos = obje.getAllEventos();
                dgvEventos.DataSource = eventos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
