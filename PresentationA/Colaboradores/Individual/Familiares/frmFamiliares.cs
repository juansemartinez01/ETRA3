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
            CargarDG();
        }

        private void CargarDG()
        {
            try
            {
                dgvFamiliares.Rows.Clear();
                DataTable familiares = familiarModelo.obtenerFamiliares(legajo);
                for (int i = 0; i < familiares.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvFamiliares.Rows.Add(familiares.Rows[i]["idFamiliar"], familiares.Rows[i]["Nombre"], familiares.Rows[i]["Apellido"], familiares.Rows[i]["Tipo Familiar"],familiares.Rows[i]["Escolarización"], familiares.Rows[i]["Fecha Nacimiento"], familiares.Rows[i]["DNI"], familiares.Rows[i]["obraSocial"], familiares.Rows[i]["trabaja"], familiares.Rows[i]["aportes"], familiares.Rows[i]["nombrecalle"], familiares.Rows[i]["numerocalle"], familiares.Rows[i]["piso"], familiares.Rows[i]["departamento"], familiares.Rows[i]["localidad"], familiares.Rows[i]["provincia"], familiares.Rows[i]["idDireccion"]);
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
            dgvFamiliares.Enabled = true;
            txtnombre.Enabled= false;
            txtapellido.Enabled= false;
            txtdni.Enabled = false;
            cmbParentezco.Enabled = false;
            dtpfechaNacimiento.Enabled = false;
            cmbescolarizacion.Enabled = false;
            txtobraSocial.Enabled = false;
            chktrabaja.Enabled = false;
            chkaportes.Enabled = false;
            txtnumerocalle.Enabled = false;
            txtnombrecalle.Enabled = false;
            txtlocalidad.Enabled = false;
            txtprovincia.Enabled = false;
            txtpiso.Enabled = false;
            txtdepartamento.Enabled = false;


            txtnombre.Text = "";
            txtapellido.Text = "";
            txtdni.Text = "";
            cmbParentezco.Text = null;
            cmbescolarizacion.Text = null;
            txtobraSocial.Text = "";
            chktrabaja.Checked = false;
            chkaportes.Checked = false;
            txtnumerocalle.Text = "";
            txtnombrecalle.Text = "";
            txtlocalidad.Text = "";
            txtprovincia.Text = "";
            txtpiso.Text = "";
            txtdepartamento.Text = "";

            btnAgregar.Visible = true;
            btnEliminar.Visible = true;
            btnEliminar.Enabled = false;

            btnModificar.Enabled = false;
            btnModificar.Text = "Modificar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;

            
        }

        private void ModifyState()
        {
            if(btnModificar.Text == "Guardar")
            {
                
                int esEdificio = 0;

                if (txtpiso.Text != "" & txtdepartamento.Text != "") { esEdificio = 1; }

                if (txtnombre.Text == "")
                {
                    MessageBox.Show("No puede dejar el nombre vacío");
                    return;
                }
                if (txtapellido.Text == "")
                {
                    MessageBox.Show("No puede dejar el apellido vacío");
                    return;
                }
                if (cmbParentezco.SelectedValue.ToString() == null)
                {
                    MessageBox.Show("Debe seleccionar un tipo de parentezco");
                    return;
                }
                if (txtdni.Text == "")
                {
                    MessageBox.Show("No puede dejar el DNI vacío");
                    return;
                }
                if (txtnombrecalle.Text == "")
                {
                    MessageBox.Show("No puede dejar la calle vacía");
                    return;
                }



                if (txtnumerocalle.Text == "")
                {
                    MessageBox.Show("No puede dejar el numero de calle vacío");
                    return;
                }

                int piso = -1;
                string depto;
                if (txtpiso.Text == "")
                {
                    piso = 0;
                    depto = "No especifica";
                }
                else
                {
                    piso = Int32.Parse(txtpiso.Text);
                    depto = "No especifica";
                    if (txtdepartamento.Text != "")
                    {
                        depto = txtdepartamento.Text;
                    }
                }

                if (txtlocalidad.Text == "")
                {
                    MessageBox.Show("No puede dejar la localidad vacía");
                    return;
                }
                if (txtprovincia.Text == "")
                {
                    MessageBox.Show("No puede dejar la provincia vacía");
                    return;
                }
                int idFamiliar = Int32.Parse(dgvFamiliares.SelectedRows[0].Cells["idFamiliar"].Value.ToString());
                int idDireccion = Int32.Parse(dgvFamiliares.SelectedRows[0].Cells["idDireccion"].Value.ToString());
                DateTime fechaNacimiento = dtpfechaNacimiento.Value;
                MessageBox.Show(familiarModelo.ModificarFamiliarColaborador(txtnombrecalle.Text, int.Parse(txtnumerocalle.Text), esEdificio, piso, depto, txtlocalidad.Text, txtprovincia.Text, idDireccion, int.Parse(cmbParentezco.SelectedValue.ToString()), legajo, txtnombre.Text, txtapellido.Text, fechaNacimiento, int.Parse(txtdni.Text), int.Parse(cmbescolarizacion.SelectedValue.ToString()), idFamiliar, txtobraSocial.Text, chktrabaja.Checked ? 1 : 0, 0, chkaportes.Checked ? 1 : 0));
                ViewState();
                CargarDG();
                return;

            }
            btnAgregar.Visible = false;
            btnEliminar.Visible = false;

            txtnombre.Enabled = true;
            txtapellido.Enabled = true;
            txtdni.Enabled = true;
            cmbParentezco.Enabled = true;
            dtpfechaNacimiento.Enabled = true;
            cmbescolarizacion.Enabled = true;
            txtobraSocial.Enabled = true;
            chktrabaja.Enabled = true;
            chkaportes.Enabled = true;
            txtnumerocalle.Enabled = true;
            txtnombrecalle.Enabled = true;
            txtlocalidad.Enabled = true;
            txtprovincia.Enabled = true;
            txtpiso.Enabled = true;
            txtdepartamento.Enabled = true;
            dgvFamiliares.Enabled = false;

            btnModificar.Visible = true;
            btnModificar.Text = "Guardar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
        }


        private void btnModificar_Click(object sender, EventArgs e)
        {
            ModifyState();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el familiar?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }
            if (dgvFamiliares.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe seleccionar un familiar");
                return;
            }
            DataGridViewRow filaSeleccionada = dgvFamiliares.SelectedRows[0];
            int idFamiliar = int.Parse(filaSeleccionada.Cells["idFamiliar"].Value.ToString());
            FamiliarColaboradorModelo familiar = new FamiliarColaboradorModelo();
            familiar.EliminarFamiliarColaborador(idFamiliar);
            CargarDG();

        }

        private void dgvFamiliares_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataTable familiar = new DataTable();
            foreach (DataGridViewColumn column in dgvFamiliares.Columns)
                familiar.Columns.Add(column.Name); //better to have cell type
            for (int i = 0; i < 1; i++)
            {
                familiar.Rows.Add();
                for (int j = 0; j < dgvFamiliares.Columns.Count; j++)
                {
                    familiar.Rows[i][j] = dgvFamiliares.SelectedRows[i].Cells[j].Value;
                }
            }

            ViewState();
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            completarLabels(this, familiar, "dtp");
            completarLabels(this, familiar, "txt");
            completarLabels(this, familiar, "cmb");
            if (familiar.Rows[0][8].ToString() == "No") { chktrabaja.Checked = false; }
            else { chktrabaja.Checked = true; }
            if (familiar.Rows[0][9].ToString() == "No") { chkaportes.Checked = false; }
            else { chkaportes.Checked = true; }
        }
    }
}
