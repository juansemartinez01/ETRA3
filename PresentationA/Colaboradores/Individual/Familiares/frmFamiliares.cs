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

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmFamiliares : frmHijo
    {
        DataTable colaboradorModelo;
        int legajo;
        FamiliarColaboradorModelo familiarModelo = new FamiliarColaboradorModelo();
        public frmFamiliares(DataTable colaborador)
        {
            InitializeComponent();
            colaboradorModelo = colaborador;
            legajo = Int32.Parse(colaboradorModelo.Rows[0]["legajo"].ToString());
            //JUANSE: Metodo para cargar datagridview
            ViewState();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            LlenarCombo(cmbescolarizacion, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Escolaridad"), "nombre", "id");
            LlenarCombo(cmbParentezco, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoFamiliar"), "nombre", "idTipoFamiliar");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {

            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = 0;
            CargarDG(legajo);
        }

        private void CargarDG(int legajo)
        {
            try
            {
                dgvFamiliares.Rows.Clear();
                DataTable familiares = familiarModelo.obtenerFamiliares(legajo);
                for (int i = 0; i < familiares.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvFamiliares.Rows.Add(familiares.Rows[i]["idFamiliar"], familiares.Rows[i]["Nombre"], familiares.Rows[i]["Apellido"], familiares.Rows[i]["Tipo Familiar"],familiares.Rows[i]["Escolarización"], familiares.Rows[i]["Fecha Nacimiento"], familiares.Rows[i]["DNI"], familiares.Rows[i]["nombrecalle"], familiares.Rows[i]["numerocalle"], familiares.Rows[i]["piso"], familiares.Rows[i]["departamento"], familiares.Rows[i]["localidad"], familiares.Rows[i]["provincia"]);
                }


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarFam agregar = new frmAgregarFam(colaboradorModelo);
            agregar.ShowDialog();
        }

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void ViewState()
        {
            txtnombre.Enabled= false;
            txtdni.Enabled = false;
            cmbParentezco.Enabled = false;
            dtpfechaNacimiento.Enabled = false;
            cmbescolarizacion.Enabled = false;

            btnModificar.Visible = true;
            btnModificar.Text = "Modificar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;

        }

        private void ModifyState()
        {
            if(btnModificar.Text == "Guardar")
            {
                //JUANSE AGREGAR ACA METODO DE Guardar cambios

                txtnombre.Enabled = false;
                txtdni.Enabled = false;
                cmbParentezco.Enabled = false;
                dtpfechaNacimiento.Enabled = false;
                cmbescolarizacion.Enabled = false;


                btnModificar.Text = "Modificar";
                btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;
                return;

            }
            txtnombre.Enabled = true;
            txtdni.Enabled = true;
            cmbParentezco.Enabled = true;
            dtpfechaNacimiento.Enabled = true;
            cmbescolarizacion.Enabled = true;
            btnEliminar.Enabled = false;


            btnModificar.Visible = true;
            btnModificar.Text = "Guardar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
        }

        private void dgvFamiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModifyState();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el colaborador?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }

            //JUANSE: eliminar familiar

        }

    }
}
