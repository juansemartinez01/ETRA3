using Common.Cache;
using DomainA;
using Microsoft.Win32;
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
    public partial class frmHistorialSalario : frmHijo
    {
        Salario salarioModelo = new Salario();
        public frmHistorialSalario(string legajo)
        {
            InitializeComponent();
            CargarDG(legajo);
            salarioModelo.legajoColaborador = int.Parse(legajo);
            dtpfechaInicio.Format = DateTimePickerFormat.Custom;
            dtpfechaInicio.CustomFormat = "dd/MM/yyyy";
            dtpfechaFin.Format = DateTimePickerFormat.Custom;
            dtpfechaFin.CustomFormat = "dd/MM/yyyy";
            ViewState();
        }
        private void CargarDG(string legajo)
        {
            try
            {
                dgvSalarios.Rows.Clear();
                DataTable salarioModeloarios = salarioModelo.obtenerSalarios(legajo);
                for (int i = 0; i < salarioModeloarios.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvSalarios.Rows.Add(salarioModeloarios.Rows[i]["Monto"], salarioModeloarios.Rows[i]["Fecha de Inicio"], salarioModeloarios.Rows[i]["Fecha Fin"]);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            
            if (btnAgregar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (txtmonto.Text == "")
                {
                    MessageBox.Show("Debe ingresar un monto.");
                    return;
                }
                string respuesta = salarioModelo.modificarSalarioColaborador(salarioModelo.legajoColaborador, float.Parse(txtmonto.Text));
                MessageBox.Show(respuesta);
                CargarDG(salarioModelo.legajoColaborador.ToString());

                ViewState();
                return;
            }
            AddState();
        }

        private void dgvSalarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            //salarioModelo.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvSalarios.Rows[indice];
            //completarLabels(this, historial, "txt");
            txtmonto.Text = filaSeleccionada.Cells["monto"].Value.ToString();
            dtpfechaInicio.Text = filaSeleccionada.Cells["fechaDeInicio"].Value.ToString();
            dtpfechaFin.Text = filaSeleccionada.Cells["fechaFin"].Value.ToString();
            ViewState();
        }

        private void ViewState()
        {
            
            dtpfechaFin.Enabled = false;
            dtpfechaInicio.Enabled = false;
            txtmonto.Enabled = false;


            dtpfechaInicio.Value = DateTime.Now;
            dtpfechaFin.Value = DateTime.Now;
            txtmonto.Text = null;

            btnAgregar.Text = "Agregar";
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            
            dgvSalarios.Enabled = true;
            return;
        }
        private void AddState()
        {
            btnAgregar.Text = "Guardar";
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            txtmonto.Enabled = true;
            
            dgvSalarios.Enabled = false;
            return;
        }
        private void txtmonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void frmHistorialSalario_Load(object sender, EventArgs e)
        {
            if(UserCache.perfil != Perfiles.admin) { btnAgregar.Enabled = false; }
        }
    }
}
