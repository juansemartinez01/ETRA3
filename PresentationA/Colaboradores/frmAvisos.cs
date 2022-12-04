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
        AvisosModelo avisosModelo = new AvisosModelo();
        public frmAvisos()
        {
            InitializeComponent();
            cargarGrillasCumpleaños();
            LlenarCombo(cmbTipoEvento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoAviso WHERE borradoLogico = 0"), "nombre", "id_tipoAviso");
            LlenarCombo(cmbCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_Cargo");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        public void cargarGrillasCumpleaños()
        {
            DataTable cumpleañosColaboradores = new DataTable();
            DataTable cumpleañosFamiliares = new DataTable();
            DataTable avisos = new DataTable();
            try
            {
                dgvAvisos.Rows.Clear();
                cumpleañosColaboradores = notificacion.notificacionesDeCumpleaños();
                avisos = avisosModelo.getAllAvisosMesActual();
                for (int i = 0; i < cumpleañosColaboradores.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    //dgvAvisos.Rows.Add(cumpleañosColaboradores.Rows[i]["Nombre"], cumpleañosColaboradores.Rows[i]["Apellido"], cumpleañosColaboradores.Rows[i]["Cumpleaños"]);
                    dgvAvisos.Rows.Add(cumpleañosColaboradores.Rows[i]["Nombre"]);
                    
                }
                
                cumpleañosFamiliares = notificacion.cumpleañosFamiliaresColaboradores();
                dgvAvisos.DataSource = avisos;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtLegajos.Text == "")
            {
                MessageBox.Show("Debe agregar al menos un legajo.");
                return;
            }
            int[] legajos = new int[10];
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
            
            string descripcion = txtDescripcion.Text;
            DateTime fechaOcurrencia = dtpfechaInicio.Value.Date;
            DateTime fechaNotificacion = dtpFechaNotificacion.Value.Date;
            int idTipoAviso = int.Parse(cmbTipoEvento.SelectedValue.ToString());

            string mensaje = avisosModelo.crearAviso(idTipoAviso, descripcion, fechaOcurrencia, fechaNotificacion, legajos);
            MessageBox.Show(mensaje);

        }
    }
}
