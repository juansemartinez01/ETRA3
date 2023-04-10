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

namespace PresentationA.Colaboradores.TodosFamiliares
{
    public partial class frmTodosModificarFamiliar : frmHijo
    {
        FamiliarColaboradorModelo familiarModificado = new FamiliarColaboradorModelo();
        bool hayCambios = false;
        public frmTodosModificarFamiliar(FamiliarColaboradorModelo familiarModificado1)
        {
            
            InitializeComponent();
            familiarModificado.idFamiliar = familiarModificado1.idFamiliar;
            familiarModificado.idDireccion = familiarModificado1.idDireccion;
            hayCambios = false;
            LlenarCombo(cmbLegajo, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbEscolariazacion, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Escolaridad"), "nombre", "id");
            LlenarCombo(cmbParentezco, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoFamiliar"), "nombre", "idTipoFamiliar");
            txtCalle.Enabled = true;
            txtNroCalle.Enabled = true;
            txtDepto.Enabled = true;
            txtLocalidad.Enabled = true;
            txtProv.Enabled = true;
            txtPiso.Enabled = true;
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = 0;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(cmbLegajo.SelectedValue.ToString());
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int parentezco = int.Parse(cmbParentezco.SelectedValue.ToString());
            DateTime fecha = dtpFechaNac.Value.Date;
            MessageBox.Show("Familiar modificado con exito!");
            int escolarizacion = int.Parse(cmbEscolariazacion.SelectedValue.ToString());
            int dni = int.Parse(txtDni.Text);
            string obraSocial = txtObraSocial.Text;
            string calle = txtCalle.Text;
            int numero = int.Parse(txtNroCalle.Text);
            int piso = int.Parse(txtPiso.Text);
            string depto = txtDepto.Text;
            string localidad = txtLocalidad.Text;
            string provincia = txtProv.Text;
            familiarModificado.ModificarFamiliarColaborador(calle, numero, 0, piso, depto, localidad, provincia, familiarModificado.idDireccion, parentezco, legajo, nombre, apellido, fecha, dni, escolarizacion, familiarModificado.idFamiliar, obraSocial, 1, 1, 1);
            this.Close();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;
        }

        private void frmTodosModificarFamiliar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hayCambios == true)
            {
                if (DialogResult.No == MessageBox.Show("Esta seguro que desea descartar los cambios?", "AVISO", MessageBoxButtons.YesNo))
                {
                    e.Cancel = true;
                    return;
                }
            }
        }

    }
}
