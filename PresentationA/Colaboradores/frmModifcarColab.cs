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

namespace PresentationA.Colaboradores
{
    public partial class frmModifcarColab : frmHijo
    {
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        Eventos evento = new Eventos();
        public frmModifcarColab(DataTable colaborador)
        {
            InitializeComponent();
            completarLabels(this, colaborador, "lbl");
            completarLabels(this, colaborador, "txt");
            
            LlenarCombo(cmbEstado, DataManager.GetInstance().ConsultaSQL("SELECT * FROM EstadoColaborador WHERE borradoLogico = 0"), "nombre", "id_estado");
            LlenarCombo(cmbLegajoResponsable, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbPuesto, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            cmbEstado.SelectedValue = evento.buscarIdConNombre(colaborador.Rows[0]["nombreEstado"].ToString(), "EstadoColaborador");
            cmbPuesto.SelectedValue = evento.buscarIdConNombre(colaborador.Rows[0]["nombreCargo"].ToString(), "Cargo");



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
            if (MessageBox.Show("Desea guardar los cambios?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                int legajo = int.Parse(lbllegajo.Text.ToString());
                string nombre = txtNombre.Text;
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("No puede dejar el nombre vacio");
                    return;
                }
                string apellido = txtApellido.Text;
                if (txtApellido.Text == "")
                {
                    MessageBox.Show("No puede dejar el apellido vacio");
                    return;
                }
                string Cuit = txtCuit.Text;
                if (txtCuit.Text == "")
                {
                    MessageBox.Show("No puede dejar el Cuit vacio");
                    return;
                }
                int dni = int.Parse(txtDni.Text);
                if (txtDni.Text == "")
                {
                    MessageBox.Show("No puede dejar el Dni vacio");
                    return;
                }
                DateTime fechaNacimiento = dtpFechaNacimiento.Value.Date;
                if (dtpFechaNacimiento.Value.Date == DateTime.Now)
                {
                    MessageBox.Show("Debe ingresar una fecha de nacimiento valida");
                    return;
                }
                string calle = txtCalle.Text;
                if (txtCalle.Text == "")
                {
                    MessageBox.Show("No puede dejar la calle vacia");
                    return;
                }
                int numeroCalle = int.Parse(txtNumeroCalle.Text);
                if (txtNumeroCalle.Text == "")
                {
                    MessageBox.Show("No puede dejar el numero de calle vacio");
                    return;
                }
                int piso = -1;
                string departamento;
                if (txtPiso.Text == "")
                {
                    piso = 0;
                    departamento = "No aplica";
                }
                else
                {
                    piso = 1;
                    departamento = "No especifica";
                    if (txtDepartamento.Text != "")
                    {
                        departamento = txtDepartamento.Text;
                    }
                }
                string localidad = txtLocalidad.Text;
                if (txtLocalidad.Text == "")
                {
                    localidad = "No especifica";
                }
                string mail = txtMail.Text;
                if (txtMail.Text == "")
                {
                    mail = "No especifica";
                }
                string numeroContacto = txtNroContacto.Text;
                if (txtNroContacto.Text == "")
                {
                    numeroContacto = "No especifica";
                }
                string numeroEmergencia = txtNroEmergencia.Text;
                if (txtNroEmergencia.Text == "")
                {
                    numeroEmergencia = "No especifica";
                }
                int estado = int.Parse(cmbEstado.SelectedValue.ToString());
                string obraSocial = txtObraSocial.Text;
                if (txtObraSocial.Text == "")
                {
                    obraSocial = "No especifica";
                }
                int puesto = int.Parse(cmbPuesto.SelectedValue.ToString());
                int legajoResponsable = 10000;


                MessageBox.Show(colaboradorModelo.modificarColaborador(legajo, nombre, apellido, fechaNacimiento, Cuit, dni, calle, numeroCalle, piso, departamento, localidad, mail, numeroContacto, numeroEmergencia, estado, obraSocial, puesto, legajoResponsable));

            }

        }
    }
}
