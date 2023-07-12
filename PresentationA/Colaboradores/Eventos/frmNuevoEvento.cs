using System;
using System.IO;
using System.Windows.Forms;
using DomainA;
using Microsoft.Win32;

namespace PresentationA.Colaboradores.Eventos
{
    public partial class frmNuevoEvento : frmHijo

    {
        EventosModelo eventosModelo = new EventosModelo();
        DocumentosColaborador nuevoDocumento = new DocumentosColaborador();
        public frmNuevoEvento()
        {
            InitializeComponent();
            LlenarCombo(cmbColaboradores2, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbTipoEvento2, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            LlenarCombo(cmbTipoMultimedia, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMultimedia WHERE borradoLogico = 0"), "nombre", "id_tipoMultimedia");
            openFileDialog1.InitialDirectory = "no seleccionado";
            //nuevoDocumento.LegajoColaborador = int.Parse(legajo);
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        public void agregarArchivoEvento(int idEvento)
        {


            byte[] archivo = null;
            // bug, cancelar un archivo a subir hace esto
            using (Stream MyStream = openFileDialog1.OpenFile())
            {
                using (MemoryStream obj = new MemoryStream())
                {
                    MyStream.CopyTo(obj);
                    archivo = obj.ToArray();

                }
            }

            //Agregamos los atributos del objeto DocumentosColaborador
            nuevoDocumento.Nombre = "ArchivoCualquiera";
            nuevoDocumento.Documento = archivo;
            nuevoDocumento.Extension = openFileDialog1.SafeFileName;
            nuevoDocumento.Id_tipoMultimedia = int.Parse(cmbTipoMultimedia.SelectedValue.ToString());
            //Despues arreglar bien esto!!!!!
            if (idEvento == 0)
            {
                idEvento = int.Parse(eventosModelo.buscarUltimoEvento());
            }
            string variableMuerta = nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, (int)cmbColaboradores2.SelectedValue, idEvento);

            //Parte para ver la imagen


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbTipoEvento2.SelectedIndex != -1)
            {

                if (cmbColaboradores2.SelectedIndex != -1)
                {
                    EventosModelo evento = new EventosModelo();
                    string respuesta = evento.InsertarEventos((int)cmbTipoEvento2.SelectedValue, (int)cmbColaboradores2.SelectedValue, txtDescripcion.Text.ToString(), dateTimePicker3.Value.Date, dateTimePicker4.Value.Date);
                    if (openFileDialog1.InitialDirectory != "no seleccionado")
                    {

                        agregarArchivoEvento(0);
                    }
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

        private void cmb_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnAgregarArchivo_Click(object sender, EventArgs e)
        {
            if (cmbTipoMultimedia.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar primero el tipo de contenido multimedia que va a subir.");
                return;
            }
            openFileDialog1.InitialDirectory = "C:\\Documentos";
            openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

            }
        }


    }
}
