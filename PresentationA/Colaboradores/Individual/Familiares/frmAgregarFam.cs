﻿using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationA.Colaboradores.Consulta.Familiares
{
    public partial class frmAgregarFam : frmHijo
    {
        bool hayCambios = false;
        string legajoColab;
        string calleColab;
        string nroCalleColab;
        string pisoColab;
        string deptoColab;
        string localidadColab;
        string provinciaColab;

        public frmAgregarFam(DataTable colaborador)
        {
            InitializeComponent();
            cargarColab(colaborador);
            hayCambios = false;
            txtCalle.Text = calleColab;
            txtNroCalle.Text = nroCalleColab;
            txtDepto.Text = deptoColab;
            txtPiso.Text = pisoColab;
            txtLocalidad.Text = localidadColab;
            txtProv.Text = provinciaColab;
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

        private void cargarColab(DataTable colaborador)
        {
            foreach (DataColumn columna in colaborador.Columns)
            {

                legajoColab = colaborador.Rows[0]["legajo"].ToString();
                calleColab = colaborador.Rows[0]["nombreCalle"].ToString();
                nroCalleColab = colaborador.Rows[0]["numeroCalle"].ToString();
                pisoColab = colaborador.Rows[0]["piso"].ToString();
                deptoColab = colaborador.Rows[0]["departamento"].ToString();
                localidadColab = colaborador.Rows[0]["localidad"].ToString();
                provinciaColab = colaborador.Rows[0]["provincia"].ToString();
            }
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            FamiliarColaboradorModelo familiar = new FamiliarColaboradorModelo();
            int esEdificio = 0;
            int escolaridad = int.Parse(cmbEscolariazacion.SelectedValue.ToString());
            int parentezco = int.Parse(cmbParentezco.SelectedValue.ToString());


            if (txtPiso.Text == "" & txtDepto.Text == "") { esEdificio =1; }

            if (txtNombre.Text == "")
            {
                MessageBox.Show("No puede dejar el nombre vacio");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("No puede dejar el apellido vacio");
                return;
            }

            if (txtDni.Text == "")
            {
                MessageBox.Show("No puede dejar el DNI vacio");
                return;
            }
            if (txtCalle.Text == "")
            {
                MessageBox.Show("No puede dejar la calle vacia");
                return;
            }

            

            if (txtNroCalle.Text == "")
            {
                MessageBox.Show("No puede dejar el numero de calle vacio");
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
                MessageBox.Show("No puede dejar la localidad vacia");
                return;
            }
            if (txtProv.Text == "")
            {
                MessageBox.Show("No puede dejar la provincia vacia");
                return;
            }

            string resultado = familiar.InsertarFamiliarColaborador(txtCalle.Text, Int32.Parse(txtNroCalle.Text),esEdificio, piso, depto,txtLocalidad.Text,txtProv.Text,parentezco,Int32.Parse(legajoColab),txtNombre.Text,txtApellido.Text,dtpFechaNac.Value.Date, Int32.Parse(txtDni.Text), escolaridad) ;
            MessageBox.Show(resultado);
            hayCambios = false;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAgregarFam_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txt_TextChanged(object sender, EventArgs e)
        {
            hayCambios= true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            txtCalle.Enabled = !ckbDirecc.Checked;
            txtNroCalle.Enabled = !ckbDirecc.Checked;
            txtDepto.Enabled = !ckbDirecc.Checked;
            txtPiso.Enabled = !ckbDirecc.Checked;
            txtLocalidad.Enabled = !ckbDirecc.Checked;
            txtProv.Enabled = !ckbDirecc.Checked;

            lblCalle.Enabled = !ckbDirecc.Checked;
            lblLocali.Enabled = !ckbDirecc.Checked;
            lblProv.Enabled = !ckbDirecc.Checked;
            lblPiso.Enabled = !ckbDirecc.Checked;
        }

    }
}
