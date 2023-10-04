using DomainA;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PresentationA.Colaboradores
{
    public partial class frmModifcarColab : frmHijo
    {
        ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
        DocumentosColaborador nuevoDocumento = new DocumentosColaborador();
        EventosModelo evento = new EventosModelo();
        bool hayCambios = false;
        public frmModifcarColab(DataTable colaborador)
        {
            InitializeComponent();
            openFileDialog2.InitialDirectory = "no seleccionado";
            completarLabels(this, colaborador, "lbl");
            completarLabels(this, colaborador, "txt");
            completarLabels(this, colaborador, "dtp");
            LlenarCombo(cmbEstado, DataManager.GetInstance().ConsultaSQL("SELECT * FROM EstadoColaborador WHERE borradoLogico = 0"), "nombre", "id_estado");
            LlenarCombo(cmbPuesto, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbSucursal, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Sucursal"), "nombre", "codigoSucursal");
            cmbEstado.SelectedValue = evento.buscarIdConNombre(colaborador.Rows[0]["nombreEstado"].ToString(), "EstadoColaborador");
            cmbPuesto.SelectedValue = evento.buscarIdConNombre(colaborador.Rows[0]["nombreCargo"].ToString(), "Cargo");
            cmbSucursal.SelectedValue = evento.buscarIdConNombre(colaborador.Rows[0]["nombreSucursal"].ToString(), "Sucursal");
            hayCambios = false;
            var Lista = new List<DocumentosColaborador>();
            Lista = nuevoDocumento.filtroDocumentosColaborador(5, (int)colaborador.Rows[0]["legajo"]);

            if (Lista.Count != 0)
            {
                string direccion = AppDomain.CurrentDomain.BaseDirectory;
                string carpeta = direccion + "/temp/";
                string ubicacionCompleta = carpeta + Lista[0].Extension;


                if (!Directory.Exists(carpeta))
                {
                    Directory.CreateDirectory(carpeta);
                }
                if (File.Exists(ubicacionCompleta))
                {
                    File.Delete(ubicacionCompleta);
                }
                File.WriteAllBytes(ubicacionCompleta, Lista[0].Documento);
                Stream fotoPerfilArchivo = File.OpenRead(ubicacionCompleta);
                Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

                pictureBox2.Image = fotoPerfil;
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
                fotoPerfilArchivo.Close();



            }
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
                    MessageBox.Show("No puede dejar el CUIT vacio");
                    return;
                }
                int dni = int.Parse(txtDni.Text);
                if (txtDni.Text == "")
                {
                    MessageBox.Show("No puede dejar el DNI vacio");
                    return;
                }
                string mail = txtmail.Text;
                if (txtmail.Text == "")
                {
                    MessageBox.Show("No puede dejar el mail vacio");
                    return;
                }
                DateTime fechaNacimiento = dtpfechaNacimiento.Value.Date;
                if (dtpfechaNacimiento.Value.Date == DateTime.Now)
                {
                    MessageBox.Show("Debe ingresar una fecha de nacimiento valida");
                    return;
                }
                string calle = txtnombreCalle.Text;
                if (txtnombreCalle.Text == "")
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
                if (txtpiso.Text == "")
                {
                    piso = 0;
                    departamento = "No aplica";
                }
                else
                {
                    piso = Int32.Parse(txtpiso.Text);
                    departamento = "No especifica";
                    if (txtdepartamento.Text != "")
                    {
                        departamento = txtdepartamento.Text;
                    }
                }
                string localidad = txtlocalidad.Text;
                if (txtlocalidad.Text == "")
                {
                    localidad = "No especifica";
                }
                string numeroContacto = txtnroContacto.Text;
                if (txtnroContacto.Text == "")
                {
                    numeroContacto = "No especifica";
                }
                string numeroEmergencia = txtnroEmergencia.Text;
                if (txtnroEmergencia.Text == "")
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
                if (cmbSucursal.SelectedValue is null)
                {
                    MessageBox.Show("Debe seleccionar una sucursal");
                    return;
                }
                if (openFileDialog2.InitialDirectory != "no seleccionado" && openFileDialog2.InitialDirectory != "C:\\Documentos")
                {

                    agregarArchivoColaborador(colaboradorModelo);
                }
                int codigoSucursal = (int)cmbSucursal.SelectedValue;

                //Aca tambien tenes que modificar Paez!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
                int estadoCivil = 1;
                int escolaridad = 1;
                
                MessageBox.Show(colaboradorModelo.modificarColaborador(legajo, nombre, apellido, fechaNacimiento, Cuit, dni, calle, numeroCalle, piso, departamento, localidad, mail, numeroContacto, numeroEmergencia, estado, obraSocial, puesto, legajoResponsable, codigoSucursal,estadoCivil,escolaridad));
                hayCambios = false;
                this.Close();
            }

        }
        public void agregarArchivoColaborador(ColaboradorModelo colaboradorModelo)
        {
            //Error, hacer click una vez en el perfil y no cargas nada y se rompe
            byte[] archivo = null;
            using (Stream MyStream = openFileDialog2.OpenFile())
            {
                using (MemoryStream obj = new MemoryStream())
                {
                    MyStream.CopyTo(obj);
                    archivo = obj.ToArray();


                }
            }






            //Agregamos los atributos del objeto DocumentosColaborador
            nuevoDocumento.Nombre = "FotoColaborador";
            nuevoDocumento.Documento = archivo;
            nuevoDocumento.Extension = openFileDialog2.SafeFileName;
            nuevoDocumento.Id_tipoMultimedia = 5;
            nuevoDocumento.LegajoColaborador = int.Parse(lbllegajo.Text.ToString());
            //Despues arreglar bien esto!!!!!
            int idEvento = colaboradorModelo.BuscarIdUltimoEvento();
            string variableMuerta = nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador, idEvento);

            //Parte para ver la imagen
            var Lista = new List<DocumentosColaborador>();
            Lista = nuevoDocumento.filtroDocumentosColaborador(nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador);

            string direccion = AppDomain.CurrentDomain.BaseDirectory;
            string carpeta = direccion + "/temp/";
            string ubicacionCompleta = carpeta + Lista[0].Extension;

            if (!Directory.Exists(carpeta))
            {
                Directory.CreateDirectory(carpeta);
            }
            if (File.Exists(ubicacionCompleta))
            {

                File.Delete(ubicacionCompleta);
            }
            File.WriteAllBytes(ubicacionCompleta, Lista[0].Documento);

            Stream fotoPerfilArchivo = File.OpenRead(ubicacionCompleta);
            Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

            pictureBox2.Image = fotoPerfil;
            fotoPerfilArchivo.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            hayCambios = true;
        }

        private void frmModifcarColab_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (hayCambios == true)
            {
                if(DialogResult.No == MessageBox.Show("Esta seguro que desea descartar los cambios?", "AVISO", MessageBoxButtons.YesNo))
                {
                e.Cancel = true; 
                return; 
                }
            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNumeroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtpiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtnroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtnroEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmbEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private string getDirectory(string path)
        {
            string[] elementos = path.Split('\\');
            string carpeta = string.Join("\\", elementos, 0, elementos.Length - 1);
            return carpeta;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog2.InitialDirectory = "C:\\Documentos";
                openFileDialog2.Filter = "Todos los archivos (*.*)|*.*";
                openFileDialog2.FilterIndex = 1;

                if (openFileDialog2.ShowDialog() == DialogResult.OK && openFileDialog2.FileName != "")
                {
                    string filePath = openFileDialog2.FileName;
                    openFileDialog2.InitialDirectory = getDirectory(filePath);

                    Stream fotoPerfilArchivo = openFileDialog2.OpenFile();
                    Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

                    pictureBox2.Image = fotoPerfil;
                    fotoPerfilArchivo.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
