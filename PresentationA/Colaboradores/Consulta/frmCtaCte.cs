using Common.Cache;
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
            lblError.Visible = false;
            colaboradorModelo.legajo = int.Parse(legajo);
            float fondoMaximo = float.Parse(cuenta.buscarFondoMaximoPermitido(colaboradorModelo.legajo));
            fondoMaximo = -fondoMaximo;
            lblFondoMaximoPermitido.Text = fondoMaximo.ToString();
            lblFondoMaximoPermitido.ForeColor = Color.Red;
            //LlenarCombo(cmbTipoMovimiento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMovimiento WHERE borradoLogico = 0 AND id_tipoMovimiento < 3"), "nombre", "id_tipoMovimiento");
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
                dgvCtaCte.Rows.Clear();
                cuentaColaborador = cuenta.buscarCuentaColaborador(int.Parse(legajo));
                for (int i = 0; i < cuentaColaborador.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvCtaCte.Rows.Add(cuentaColaborador.Rows[i]["idHistorialCuenta"],cuentaColaborador.Rows[i]["nombre"], cuentaColaborador.Rows[i]["montoMoviento"], cuentaColaborador.Rows[i]["fechaInicio"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            if(txtDepositar.Text == "")
            {
                msgError("Debe completar el monto del movimiento con un valor mayor a cero");
                return;
            }
            float monto = float.Parse(txtDepositar.Text);
            //int tipoMovimiento = int.Parse(cmbTipoMovimiento.SelectedValue.ToString());
            string mensaje = cuenta.modificarSaldo(colaboradorModelo.legajo, monto, 1);
            MessageBox.Show(mensaje);
            CargarDG(colaboradorModelo.legajo.ToString());
            buscarSaldo();
            LimpiarCampos();
            lblError.Visible = false;
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

        private void dgvBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int indice = e.RowIndex;
            
            if (indice == -1 || (indice + 1) >= (dgvCtaCte.Rows.Count))
            {
                return;
            }
            DataGridViewRow filaSeleccionada = dgvCtaCte.Rows[indice];
            cuenta.Movimientoid = int.Parse(filaSeleccionada.Cells["Numero mov."].Value.ToString());
            if(filaSeleccionada.Cells["Tipo movimiento"].Value.ToString() == "Creacion cuenta                                   ")
            {
                
                return ;
            }       
        }
        private void LimpiarCampos()
        {
            txtDepositar.Text = "";
            txtRetirar.Text = "";
            cuenta.Movimientoid = -1;
            
        }

        private void frmCtaCte_Load(object sender, EventArgs e)
        {
            if(UserCache.perfil != Perfiles.admin) { btnDepositar.Enabled = false;}
        }

        private void txtMontoMovimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            if (txtRetirar.Text == "" || txtRetirar.Text == "0")
            {
                msgError("Debe completar el monto del movimiento con un valor mayor a cero");
                return;
            }

            float monto = float.Parse(txtRetirar.Text);
            //int tipoMovimiento = int.Parse(cmbTipoMovimiento.SelectedValue.ToString());
            string mensaje = cuenta.modificarSaldo(colaboradorModelo.legajo, monto, 2);
            CargarDG(colaboradorModelo.legajo.ToString());
            buscarSaldo();
            LimpiarCampos();
            lblError.Visible = false;
        }
        private void msgError(string msg)
        {
            lblError.Text = "     " + msg;
            lblError.Visible = true;
        }

    }
}
