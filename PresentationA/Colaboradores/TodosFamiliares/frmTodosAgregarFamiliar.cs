using DomainA;
using PresentationA.Colaboradores.Consulta.Familiares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.TodosFamiliares
{
    public partial class frmTodosAgregarFamiliar : frmHijo
    {
        bool hayCambios = false;
        public frmTodosAgregarFamiliar()
        {
            InitializeComponent();
            chkDirecc.Checked = false;
            LlenarCombo(cmbLegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbEscolariazacion, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Escolaridad"), "nombre", "id");
            LlenarCombo(cmbParentezco, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoFamiliar"), "nombre", "idTipoFamiliar");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = 0;
        }

        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }


        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;
        }

        

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int legajoColab = int.Parse(cmbLegajo.SelectedValue.ToString());
            FamiliarColaboradorModelo familiar = new FamiliarColaboradorModelo();
            int esEdificio = 0;
            int escolaridad = int.Parse(cmbEscolariazacion.SelectedValue.ToString());
            int parentezco = int.Parse(cmbParentezco.SelectedValue.ToString());
            string obraSocial = txtObraSocial.Text;
            if (obraSocial == "") { obraSocial = "No especifica"; }
            int esTrabajador = 0;
            if (chkTrabaja.Checked) { esTrabajador = 1; }
            int esDependencia = 0;
            int aportes = 0;
            if (chkAportes.Checked) { aportes = 1; }



            if (cmbLegajo.SelectedValue.ToString() == null)
            {
                MessageBox.Show("Debe seleccionar un colaborador");
                return;
            }
            if (txtPiso.Text == "" & txtDepto.Text == "") { esEdificio = 1; }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("No puede dejar el nombre vacío");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("No puede dejar el apellido vacío");
                return;
            }
            if (cmbParentezco.SelectedValue.ToString() == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de parentezco");
                return;
            }
            if (txtDni.Text == "")
            {
                MessageBox.Show("No puede dejar el DNI vacío");
                return;
            }
            if (txtCalle.Text == "")
            {
                MessageBox.Show("No puede dejar la calle vacía");
                return;
            }



            if (txtNroCalle.Text == "")
            {
                MessageBox.Show("No puede dejar el numero de calle vacío");
                return;
            }

            int piso = -1;
            string depto;
            if (txtPiso.Text == "")
            {
                piso = 0;
                depto = "No aplica";
            }
            else
            {
                piso = Int32.Parse(txtPiso.Text);
                depto = "No especifica";
                if (txtDepto.Text != "")
                {
                    depto = txtDepto.Text;
                }
            }

            if (txtLocalidad.Text == "")
            {
                MessageBox.Show("No puede dejar la localidad vacía");
                return;
            }
            if (txtProv.Text == "")
            {
                MessageBox.Show("No puede dejar la provincia vacía");
                return;
            }


            string resultado = familiar.InsertarFamiliarColaborador(txtCalle.Text, Int32.Parse(txtNroCalle.Text), esEdificio, piso, depto, txtLocalidad.Text, txtProv.Text, parentezco, legajoColab, txtNombre.Text, txtApellido.Text, dtpFechaNac.Value.Date, Int32.Parse(txtDni.Text), escolaridad, obraSocial, esTrabajador, esDependencia, aportes);
            MessageBox.Show(resultado);
            hayCambios = false;
            this.Close();
        }

        private void ckbDirecc_CheckedChanged(object sender, EventArgs e)
        {
            txtCalle.Enabled = !chkDirecc.Checked;
            txtNroCalle.Enabled = !chkDirecc.Checked;
            txtDepto.Enabled = !chkDirecc.Checked;
            txtPiso.Enabled = !chkDirecc.Checked;
            txtLocalidad.Enabled = !chkDirecc.Checked;
            txtProv.Enabled = !chkDirecc.Checked;

            lblCalle.Enabled = !chkDirecc.Checked;
            lblLocali.Enabled = !chkDirecc.Checked;
            lblProv.Enabled = !chkDirecc.Checked;
            lblPiso.Enabled = !chkDirecc.Checked;
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTodosAgregarFamiliar_Load(object sender, EventArgs e)
        {

        }

        private void cmbLegajo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargar direccion colab
            hayCambios = true;
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}

