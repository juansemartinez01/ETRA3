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
            cargarGrillasCumpleaños();
        }
        public void cargarGrillasCumpleaños()
        {
            DataTable cumpleañosColaboradores = new DataTable();
            DataTable cumpleañosFamiliares = new DataTable();
            try
            {
                dgvCumpleañosDelMes.Rows.Clear();
                cumpleañosColaboradores = notificacion.notificacionesDeCumpleaños();
                for (int i = 0; i < cumpleañosColaboradores.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvCumpleañosDelMes.Rows.Add(cumpleañosColaboradores.Rows[i]["Nombre"], cumpleañosColaboradores.Rows[i]["Apellido"], cumpleañosColaboradores.Rows[i]["Cumpleaños"]);
                }
                
                cumpleañosFamiliares = notificacion.cumpleañosFamiliaresColaboradores();
                dgvCumpleañosFamiliares.DataSource = cumpleañosFamiliares;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int[] legajos = new int[50];
            string legajoCompleto = "";
            int i = 0;
            int cantidadCaracteres = 0;
            foreach(char caracter in txtLegajos.Text)
            {
                if(caracter == char.Parse(","))
                {
                    if(legajoCompleto.Length > 0)
                    {
                        legajos[i] = int.Parse(legajoCompleto);
                        i++;
                        legajoCompleto = "";
                    }
                }
                else
                {
                    
                    legajoCompleto += caracter.ToString();
                }
                cantidadCaracteres++;
            }
            if(cantidadCaracteres == txtLegajos.TextLength)
            {
                legajos[i] = int.Parse(legajoCompleto);
            }
            int posicionLegajo = 0;
            foreach(int legajo in legajos)
            {
                if(legajo == 0)
                {
                    legajos[posicionLegajo]
                }
                posicionLegajo++;
            }
        }
    }
}
