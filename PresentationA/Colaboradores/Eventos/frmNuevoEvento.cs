using System;
using System.Windows.Forms;
using DomainA;

namespace PresentationA.Colaboradores.Eventos
{
    public partial class frmNuevoEvento : frmHijo
    {
        public frmNuevoEvento()
        {
            InitializeComponent();
            LlenarCombo(cmbColaboradores2, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbTipoEvento2, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipoEvento2.SelectedIndex != -1)
            {

                if (cmbColaboradores2.SelectedIndex != -1)
                {
                    EventosModelo evento = new EventosModelo();
                    string respuesta = evento.InsertarEventos((int)cmbTipoEvento2.SelectedValue, (int)cmbColaboradores2.SelectedValue, txtDescripcion.Text.ToString(), dateTimePicker3.Value.Date, dateTimePicker4.Value.Date);
                    MessageBox.Show(respuesta);
                    this.Close();
                }
                else
                {
                    msgError("Debe seleccionar un colaborador asosciado");
                }
            }
            else
            {
                msgError("Debe seleccionar un tipo de evento");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void msgError(string msg)
        {
            lblError.Text = "      " + msg;
            lblError.Visible = true;
        }
    }
}
