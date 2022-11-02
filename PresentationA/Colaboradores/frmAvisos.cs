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
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        public frmAvisos()
        {
            InitializeComponent();
            cargarAvisos();
            LlenarCombo(cmbTipoAviso, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoAviso WHERE borradoLogico = 0"), "nombre", "id_tipoAviso");
            LlenarCombo(cmbCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_Cargo");
            txtLegajos.Enabled = true;
            cmbCargo.Enabled = false;
            lblCargo.Enabled = false;
            chkCargo.Checked = false;
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
            try
            {
                dgvAvisos.Rows.Clear();
                cumpleañosColaboradores = notificacion.notificacionesDeCumpleaños();
                for (int i = 0; i < cumpleañosColaboradores.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvAvisos.Rows.Add(cumpleañosColaboradores.Rows[i]["Nombre"], cumpleañosColaboradores.Rows[i]["Apellido"], cumpleañosColaboradores.Rows[i]["Cumpleaños"]);
                }
                
                cumpleañosFamiliares = notificacion.cumpleañosFamiliaresColaboradores();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarAvisos()
        {
            //Tenemos que traer la tabla segun los valores ingresados en el filtro, en un principio solo traemos todos los avisos
            DataTable avisos = avisosModelo.getAllAvisos();
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int[] legajos = new int[50];
            if (chkCargo.Checked)
            {
                int[] legajosDelCargo = traerLegajosPorCargo(int.Parse(cmbCargo.SelectedValue.ToString()));
                for (int i = 0; i < legajosDelCargo.Length; i++)
                {
                    legajos[i] = legajosDelCargo[i];
                }

            }
            else
            {
                if (txtLegajos.Text == "")
                {
                    MessageBox.Show("Debe agregar al menos un legajo.");
                    return;
                }
                
                string legajoCompleto = "";
                int i = 0;
                int cantidadCaracteres = 0;
                foreach (char caracter in txtLegajos.Text)
                {
                    if (caracter == char.Parse(","))
                    {
                        if (legajoCompleto.Length > 0)
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
                if (cantidadCaracteres == txtLegajos.TextLength)
                {
                    legajos[i] = int.Parse(legajoCompleto);
                }
            }

            if (txtDescripcion.Text == "")
            {
                MessageBox.Show("Debe agregar una descripcion.");
                return;
            }
            string descripcion = txtDescripcion.Text;
            DateTime fechaOcurrencia = dtpfechaOcurrencia.Value.Date;
            DateTime fechaNotificacion = dtpfechaNotificacion.Value.Date;
            if (cmbTipoAviso.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de aviso");
                return;
            }
            int idTipoAviso = int.Parse(cmbTipoAviso.SelectedValue.ToString());

            string mensaje = avisosModelo.crearAviso(idTipoAviso, descripcion, fechaOcurrencia, fechaNotificacion, legajos);
            MessageBox.Show(mensaje);
            cargarAvisos();

        }

        private void chkCargo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCargo.Checked)
            {
                txtLegajos.Enabled = false;
                cmbCargo.Enabled = true;
                lblCargo.Enabled = true;
            }
            else
            {
                txtLegajos.Enabled = true;
                cmbCargo.Enabled = false;
                lblCargo.Enabled = false;
            }
        }
        public int[] traerLegajosPorCargo(int idCargo)
        {
            int[] legajos = new int[50];
            DataTable dt = colaboradorModelo.buscarLegajosDeUnCargo(idCargo);
            int i = 0;
            foreach(DataRow row in dt.Rows)
            {
                legajos[i] = int.Parse(row["Legajo"].ToString());
                i++;
            }
            return legajos;
        }

        private void txtLegajos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != char.Parse(","))
            {
                e.Handled = true;
            }
        }
    }
}
