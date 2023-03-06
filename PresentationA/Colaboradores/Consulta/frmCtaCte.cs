using Common.Cache;
using DataAccesA;
using DomainA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            DataTable colab = colaboradorModelo.BuscarColaborador(legajo, "", "");
            colaboradorModelo.nombre = colab.Rows[0]["nombre"].ToString();
            colaboradorModelo.apellido = colab.Rows[0]["apellido"].ToString();
            colaboradorModelo.calle = colab.Rows[0]["nombreCalle"].ToString();
            colaboradorModelo.nroCalle = int.Parse(colab.Rows[0]["numeroCalle"].ToString());
            float fondoMaximo = float.Parse(cuenta.buscarFondoMaximoPermitido(colaboradorModelo.legajo));
            //fondoMaximo = -fondoMaximo;
            lblFondoMaximoPermitido.Text = fondoMaximo.ToString();
            lblFondoMaximoPermitido.ForeColor = Color.Red;
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
                    dgvCtaCte.Rows.Add(cuentaColaborador.Rows[i]["idHistorialCuenta"],cuentaColaborador.Rows[i]["nombre"], cuentaColaborador.Rows[i]["montoMoviento"], cuentaColaborador.Rows[i]["fechaInicio"], cuentaColaborador.Rows[i]["descripcion"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            string descripcion = "No especifica";
            if (txtDepositar.Text == "")
            {
                msgError("Debe completar el monto del movimiento con un valor mayor a cero");
                return;
            }
            if (txtDescripcion.Text != "")
            {
                descripcion = txtDescripcion.Text;
            }
            float monto = float.Parse(txtDepositar.Text);
            //int tipoMovimiento = int.Parse(cmbTipoMovimiento.SelectedValue.ToString());
            string mensaje = cuenta.modificarSaldo(colaboradorModelo.legajo, monto, 1, descripcion);
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
                //saldo = -saldo;
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
            txtDescripcion.Text = "";
            
        }

        private void frmCtaCte_Load(object sender, EventArgs e)
        {
            if(UserCache.perfil != Perfiles.admin) { btnDepositar.Enabled = false; btnRetirar.Enabled = false; }
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
            string descripcion = "No especifica";
            if (txtRetirar.Text == "" || txtRetirar.Text == "0")
            {
                msgError("Debe completar el monto del movimiento con un valor mayor a cero");
                return;
            }
            if (txtDescripcion.Text != "")
            {
                descripcion = txtDescripcion.Text;
            }
            float monto = float.Parse(txtRetirar.Text);
            float monto1 = monto * (-1);
            float saldoMax = float.Parse(lblFondoMaximoPermitido.Text);
            float saldoActual = float.Parse(lblSaldo.Text);
            float saldoNuevo = monto1 + saldoActual;
            if (saldoNuevo <= saldoMax) 
            {
                if (MessageBox.Show("El movimiento que quiere realizar excede al saldo maximo permitido. Desea realizarlo de todas formas? Los adminsitradores serán notificados ", "Movimiento Inválido", MessageBoxButtons.YesNo) == DialogResult.No) { return; }
            }
            
            //int tipoMovimiento = int.Parse(cmbTipoMovimiento.SelectedValue.ToString());
            string mensaje = cuenta.modificarSaldo(colaboradorModelo.legajo, monto , 2, descripcion);
            MessageBox.Show(mensaje);
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

        private void btnExportar_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Application.Workbooks.Add(true);
            int icol = 0;
            int irow = 0;
            foreach (DataGridViewColumn col in dgvCtaCte.Columns)
            {
                icol++;
                excel.Cells[1, icol] = col.Name;
                foreach (DataGridViewRow row in dgvCtaCte.Rows)
                {
                    irow++;
                    excel.Cells[irow + 1, icol] = row.Cells[col.Name].Value;
                }
                irow = 0;
            }

            excel.Visible = true;

        }
        private void generarComprobante(string tipo, float monto, string fechaMovimiento, string descrip, string nroMov)
        {
            var folderBrowserDialog1 = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result != DialogResult.OK) { return; }
            string folderName = folderBrowserDialog1.SelectedPath;
            string fileName = folderName + "\\" + tipo + "_" + "NRO" + nroMov+  "_"+ colaboradorModelo.nombre.ToString()  + colaboradorModelo.apellido.ToString() + "_" + DateTime.Now.ToString("yyyy-MM-dd") + ".pdf";

            ComprobanteModelo comprobante = new ComprobanteModelo();
            if (tipo == "PRESTAMO")
            {
                monto = monto * -1;
                MessageBox.Show(comprobante.generarOrden(colaboradorModelo.nombre.ToString() + " " + colaboradorModelo.apellido.ToString(), colaboradorModelo.calle + " " + colaboradorModelo.nroCalle.ToString(), monto, fileName, tipo, descrip, colaboradorModelo.legajo.ToString(), fechaMovimiento));
            }
            else
            {
                MessageBox.Show(comprobante.generarOrden(colaboradorModelo.nombre.ToString() + " " + colaboradorModelo.apellido.ToString(), colaboradorModelo.calle + " " + colaboradorModelo.nroCalle.ToString(), 0, fileName, tipo ,descrip, colaboradorModelo.legajo.ToString(), fechaMovimiento, monto));
            }
        }

        private void dgvCtaCte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string nroMov = dgvCtaCte.CurrentRow.Cells[0].Value.ToString();
            string tipo = dgvCtaCte.CurrentRow.Cells[1].Value.ToString().ToUpper();
            float monto = float.Parse(dgvCtaCte.CurrentRow.Cells[2].Value.ToString());
            string fechaMovimiento = dgvCtaCte.CurrentRow.Cells[3].Value.ToString();
            string descrip = dgvCtaCte.CurrentRow.Cells[4].Value.ToString();
            generarComprobante(tipo, monto, fechaMovimiento, descrip, nroMov);

        }
    }
}
