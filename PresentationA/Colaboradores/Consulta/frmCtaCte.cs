using DataAccesA;
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

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmCtaCte : frmHijo
    {
        CuentaColaboradorModelo cuenta = new CuentaColaboradorModelo();
        DataTable cuentaColaborador;
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        public frmCtaCte(string legajo)
        {
            InitializeComponent();
            colaboradorModelo.legajo = int.Parse(legajo);
            float fondoMaximo = float.Parse(cuenta.buscarFondoMaximoPermitido(colaboradorModelo.legajo));
            fondoMaximo = -fondoMaximo;
            lblFondoMaximoPermitido.Text = fondoMaximo.ToString();
            lblFondoMaximoPermitido.ForeColor = Color.Red;
            LlenarCombo(cmbTipoMovimiento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMovimiento WHERE borradoLogico = 0 AND id_tipoMovimiento < 3"), "nombre", "id_tipoMovimiento");
            CargarDG(legajo);
            buscarSaldo();
            LimpiarCampos();


        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        private void CargarDG(string legajo)
        {
            try
            {
                cuentaColaborador = cuenta.buscarCuentaColaborador(int.Parse(legajo));
                dgvBusqueda.DataSource =cuentaColaborador;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(txtMontoMovimiento.Text == "" || cmbTipoMovimiento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe completar el monto del movimiento y seleccionar un tipo de movimiento");
                return;
            }
            float monto = float.Parse(txtMontoMovimiento.Text);
            int tipoMovimiento = int.Parse(cmbTipoMovimiento.SelectedValue.ToString());
            string mensaje = cuenta.modificarSaldo(colaboradorModelo.legajo, monto, tipoMovimiento);
            MessageBox.Show(mensaje);
            CargarDG(colaboradorModelo.legajo.ToString());
            buscarSaldo();
            LimpiarCampos();
        }
        private void buscarSaldo()
        {
            float saldo = cuenta.buscarSaldo(colaboradorModelo.legajo);
            if(saldo > 0 || saldo == 0)
            {
                
                lblSaldo.Text = saldo.ToString();
                lblSaldo.ForeColor = Color.Green;
            }
            else
            {
                saldo = -saldo;
                lblSaldo.Text = saldo.ToString();
                lblSaldo.ForeColor = Color.Red;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int resultado = cuenta.eliminarMovimiento(colaboradorModelo.legajo, cuenta.Movimientoid);
            if (resultado == 0)
            {
                MessageBox.Show("ocurrio un error.");
            }
            else
            {
                MessageBox.Show("Movimiento eliminado correctamente.");
                buscarSaldo();
                CargarDG(colaboradorModelo.legajo.ToString());
                LimpiarCampos();
            }
        }

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idMovimiento = 0;
            int indice = e.RowIndex;
            
            if (indice == -1 || (indice + 1) >= (dgvBusqueda.Rows.Count))
            {
                btnVerArchivo.Enabled = false;
                btnEliminar.Enabled = false;
                
                return;
            }
            DataGridViewRow filaSeleccionada = dgvBusqueda.Rows[indice];
            cuenta.Movimientoid = int.Parse(filaSeleccionada.Cells["Numero mov."].Value.ToString());
            if(filaSeleccionada.Cells["Tipo movimiento"].Value.ToString() == "Creacion cuenta                                   ")
            {
                btnEliminar.Enabled = false;
                return ;
            }
            
            btnEliminar.Enabled = true;
            
        }
        private void LimpiarCampos()
        {
            txtMontoMovimiento.Text = "";
            cmbTipoMovimiento.SelectedIndex = -1;
            btnEliminar.Enabled = false;
            
            cuenta.Movimientoid = -1;
            
        }

        private void frmCtaCte_Load(object sender, EventArgs e)
        {

        }

        private void txtMontoMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtMontoMovimiento_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
