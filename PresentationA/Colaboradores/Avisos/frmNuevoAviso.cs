using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores
{
    public partial class frmNuevoAviso : frmHijo
    {
        AvisosModelo avisosModelo = new AvisosModelo();
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        public frmNuevoAviso()
        {
            InitializeComponent();
            txtLegajos.Enabled = true;
            cmbCargo.Enabled = false;
            lblCargo.Enabled = false;
            chkCargo.Checked = false;
            LlenarCombo(cmbTipoAviso, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoAviso WHERE borradoLogico = 0"), "nombre", "id_tipoAviso");
            LlenarCombo(cmbCargo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_Cargo");

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        private void txtLegajos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && e.KeyChar != char.Parse(","))
            {
                e.Handled = true;
            }
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
            foreach (DataRow row in dt.Rows)
            {
                legajos[i] = int.Parse(row["Legajo"].ToString());
                i++;
            }
            return legajos;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                    msgError("Debe agregar al menos un legajo.");
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
                msgError("Debe agregar una descripcion.");
                return;
            }
            string descripcion = txtDescripcion.Text;
            DateTime fechaOcurrencia = dtpfechaOcurrencia.Value.Date;
            DateTime fechaNotificacion = dtpfechaNotificacion.Value.Date;
            if (cmbTipoAviso.SelectedIndex == -1)
            {
                msgError("Debe seleccionar un tipo de aviso");
                return;
            }
            int idTipoAviso = int.Parse(cmbTipoAviso.SelectedValue.ToString());

            string mensaje = avisosModelo.crearAviso(idTipoAviso, descripcion, fechaOcurrencia, fechaNotificacion, legajos);
            MessageBox.Show(mensaje);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
    }
}
