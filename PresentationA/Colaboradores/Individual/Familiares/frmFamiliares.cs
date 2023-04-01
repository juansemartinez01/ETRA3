﻿using DomainA;
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
                    dgvFamiliares.Rows.Add(familiares.Rows[i]["idFamiliar"], familiares.Rows[i]["Nombre"], familiares.Rows[i]["Apellido"], familiares.Rows[i]["Tipo Familiar"],familiares.Rows[i]["Escolarización"], familiares.Rows[i]["Fecha Nacimiento"], familiares.Rows[i]["DNI"], familiares.Rows[i]["obraSocial"], familiares.Rows[i]["trabaja"], familiares.Rows[i]["aportes"], familiares.Rows[i]["nombrecalle"], familiares.Rows[i]["numerocalle"], familiares.Rows[i]["piso"], familiares.Rows[i]["departamento"], familiares.Rows[i]["localidad"], familiares.Rows[i]["provincia"]);
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
            btnModificar.Enabled = true;
            btnModificar.Text = "Modificar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;

        }

        private void ModifyState()
        {
            if(btnModificar.Text == "Guardar")
            {
                //JUANSE AGREGAR ACA METODO DE Guardar cambios
                ViewState();
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
            if (DialogResult.No == MessageBox.Show("Esta seguro que desea eliminar el colaborador?", "AVISO", MessageBoxButtons.YesNo))
            {
                return;
            }

            //JUANSE: eliminar familiar

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