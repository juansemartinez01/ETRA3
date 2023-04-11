using DomainA;
using System;
using System.Data;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.TodosFamiliares
{
    public partial class frmTodosModificarFamiliar : frmHijo
    {
        FamiliarColaboradorModelo familiarModificado = new FamiliarColaboradorModelo();
        bool hayCambios = false;
        int legajo;
        public frmTodosModificarFamiliar(DataTable familiar)
        {
            
            InitializeComponent();
            familiarModificado.idFamiliar = int.Parse(familiar.Rows[0]["idFamiliar"].ToString());
            familiarModificado.idDireccion = int.Parse(familiar.Rows[0]["idDireccion"].ToString());
            legajo = int.Parse(familiar.Rows[0]["legajo"].ToString());
            completarLabels(this, familiar, "dtp");
            completarLabels(this, familiar, "txt");
            completarLabels(this, familiar, "cmb");
            hayCambios = false;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int parentezco = int.Parse(cmbParentezco.SelectedValue.ToString());
            DateTime fecha = dtpFechaNac.Value.Date;
            
            int escolarizacion = int.Parse(cmbEscolariazacion.SelectedValue.ToString());
            int dni = int.Parse(txtDni.Text);
            string obraSocial = txtObraSocial.Text;
            string calle = txtCalle.Text;
            int numero = int.Parse(txtNroCalle.Text);
            int piso = int.Parse(txtPiso.Text);
            string depto = txtDepto.Text;
            string localidad = txtLocalidad.Text;
            string provincia = txtProv.Text;
            MessageBox.Show(familiarModificado.ModificarFamiliarColaborador(calle, numero, 0, piso, depto, localidad, provincia, familiarModificado.idDireccion, parentezco, legajo, nombre, apellido, fecha, dni, escolarizacion, familiarModificado.idFamiliar, obraSocial, 1, 1, 1));
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
