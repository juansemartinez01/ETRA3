 using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DomainA;
namespace PresentationA.Colaboradores
{
    public partial class frmCargaColab : frmHijo
    {
        CuentaColaboradorModelo cuentaColaborador = new CuentaColaboradorModelo();
        DocumentosColaborador nuevoDocumento = new DocumentosColaborador();
        private List<string> camposObligatorios = new List<string>()
        {
            "txtNombre", "txtApellido","txtDni","txtCuit", "txtCalle","txtNroCalle", "cmbPuesto"
        };
        public frmCargaColab()
        {

            InitializeComponent();
            openFileDialog1.InitialDirectory = "no seleccionado";
            LlenarCombo(cmbEstados, DataManager.GetInstance().ConsultaSQL("SELECT * FROM EstadoColaborador WHERE borradoLogico = 0"), "nombre", "id_estado");
            LlenarCombo(cmbPuesto, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Cargo WHERE borradoLogico = 0"), "nombre", "id_cargo");
            LlenarCombo(cmbSucursal, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Sucursal"), "nombre", "codigoSucursal");
            chkIngresaHoy.Checked = true;
            dtpFechaingreso.Enabled = false;

        }
        //private void validarCamposObligatorios()
        //{
        //    foreach (string campo in camposObligatorios)
        //    {
        //        var control = this.Controls.Find(campo, true);
        //        if (control[0].Text == string.Empty)
        //        {
        //            Control labelControl = this.Controls.Find("lbl" + campo, true);
        //            labelControl.BackColor = Colors.Red;
        //        }
        //    }
        //}
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }



        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int codigoSucursal = (int)cmbSucursal.SelectedValue;
            DateTime fechaNacimiento = dtpfechaNacimiento.Value.Date;
            DateTime fechaIngreso;
            string obraSocial = txtObraSocial.Text;
            int legajoResponsable = 10000;
            if (chkIngresaHoy.Checked)
            {
                fechaIngreso = DateTime.Now;
            }
            else
            {
                fechaIngreso = dtpFechaingreso.Value.Date;
            }
            if (dtpfechaNacimiento.Value.Date.Year == DateTime.Now.Year)
            {
                MessageBox.Show("Debe ingresar una fecha de nacimiento valida");
                return;
            }
            if(txtObraSocial.Text == "")
            {
                obraSocial = "No especifica";
            }
            

            string telefonoEmergencia = txtNroEmergencia.Text;
            string telefonoContacto = txtNroContacto.Text;
            string mail = txtMail.Text;
            if(txtMail.Text == "")
            {
                MessageBox.Show("Debe asignarle un mail al colaborador.");
                return;
            }
            if(txtNroEmergencia.Text == "")
            {
                telefonoEmergencia = "No especifica";
            }
            if(txtNroContacto.Text == "")
            {
                telefonoContacto = "No especifica";
            }
            if(txtSalario.Text == "")
            {
                MessageBox.Show("Debe asignarle un salario al colaborador.");
                return;
            }
            if (codigoSucursal == -1)
            {
                MessageBox.Show("Debe asignarle una sucursal al colaborador.");
                return;
            }

            double prestamoMaximo = ((30 * float.Parse(txtSalario.Text)) / 100);
            prestamoMaximo = Math.Round(prestamoMaximo);

            
            if (cmbEstados.SelectedIndex == -1)
            {
                cmbEstados.SelectedIndex = 0;
            }
            string provincia = "Cordoba";
            string departamento;
            string localidad;
            
            
            if (txtLocalidad.Text != "")
            {
                localidad = txtLocalidad.Text.ToString();
            }
            else
            {
                localidad = "No especifica";
            }
            if (txtNombre.Text != "")
            {
                if (txtApellido.Text != "")
                {
                    if (txtDni.Text != "")
                    {
                        if (txtCuit.Text != "")
                        {
                            if (txtCalle.Text != "")
                            {
                                if (txtNroCalle.Text != "")
                                {



                                    if (cmbPuesto.SelectedIndex != -1)
                                    {
                                        int piso;
                                        if (txtPiso.Text != "")
                                        {
                                            piso = int.Parse(txtPiso.Text.ToString());
                                            if (txtDepto.Text != "")
                                            {
                                                departamento = txtDepto.Text.ToString();
                                                ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
                                                var cadenaRespuesta = colaboradorModelo.CrearColaborador(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtCuit.Text, txtCalle.Text, int.Parse(txtNroCalle.Text), (int)cmbPuesto.SelectedValue, piso, departamento, localidad, provincia, (int)cmbEstados.SelectedValue,float.Parse(txtSalario.Text.ToString()),mail,telefonoContacto,telefonoEmergencia,fechaNacimiento,fechaIngreso,obraSocial,legajoResponsable,codigoSucursal);
                                                if (openFileDialog1.InitialDirectory != "no seleccionado" && openFileDialog1.InitialDirectory != "C:\\Documentos")
                                                {

                                                    agregarArchivoColaborador(colaboradorModelo);
                                                }
                                                string masnsajeCuentaCreada = cuentaColaborador.crearCuentaColaborador(int.Parse(colaboradorModelo.BuscarLegajoUltimoColaborador()), prestamoMaximo);

                                                MessageBox.Show(cadenaRespuesta);
                                                limpiarCampos();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Debe asignarle un departamento al colaborador(A,B,C...)");
                                            }
                                        }
                                        else
                                        {
                                            piso = 0;
                                            departamento = "No especifica";
                                            ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
                                            var cadenaRespuesta = colaboradorModelo.CrearColaborador(txtNombre.Text, txtApellido.Text, int.Parse(txtDni.Text), txtCuit.Text, txtCalle.Text, int.Parse(txtNroCalle.Text), (int)cmbPuesto.SelectedValue, piso, departamento, localidad, provincia, (int)cmbEstados.SelectedValue, float.Parse(txtSalario.Text.ToString()), mail, telefonoContacto, telefonoEmergencia, fechaNacimiento, fechaIngreso, obraSocial, legajoResponsable, codigoSucursal);
                                            if (openFileDialog1.InitialDirectory != "no seleccionado" && openFileDialog1.InitialDirectory != "C:\\Documentos")
                                            {

                                                agregarArchivoColaborador(colaboradorModelo);
                                            }
                                            string masnsajeCuentaCreada = cuentaColaborador.crearCuentaColaborador(int.Parse(colaboradorModelo.BuscarLegajoUltimoColaborador()), prestamoMaximo);
                                            MessageBox.Show(cadenaRespuesta);
                                            limpiarCampos();
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe asignarle un puesto al colaborador");
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Debe completar el numero de la calle.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Debe completar la calle.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe completar el CUIT/CUIL");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe completar el DNI");
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar el apellido");
                }
            }
            else
            {
                MessageBox.Show("Debe completar el nombre");
            }
        }



        public void agregarArchivoColaborador(ColaboradorModelo colaboradorModelo)
        {
            //Error, hacer click una vez en el perfil y no cargas nada y se rompe
            byte[] archivo = null;
            using (Stream MyStream = openFileDialog1.OpenFile())
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
            nuevoDocumento.Extension = openFileDialog1.SafeFileName;
            nuevoDocumento.Id_tipoMultimedia = 5;
            nuevoDocumento.LegajoColaborador = int.Parse(colaboradorModelo.BuscarLegajoUltimoColaborador());
            //Despues arreglar bien esto!!!!!
            int idEvento = colaboradorModelo.BuscarIdUltimoEvento();
            string variableMuerta = nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador,idEvento);

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

            pictureBox1.Image = fotoPerfil;
            fotoPerfilArchivo.Close();

        }

        private string getDirectory(string path) 
        {
            string[] elementos = path.Split('\\');
            string carpeta = string.Join("\\", elementos, 0, elementos.Length - 1);
            return carpeta;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.InitialDirectory = "C:\\Documentos";
                openFileDialog1.Filter = "Todos los archivos (*.*)|*.*";
                openFileDialog1.FilterIndex = 1;

                if (openFileDialog1.ShowDialog() == DialogResult.OK && openFileDialog1.InitialDirectory != "")
                {
                    string filePath = openFileDialog1.FileName;
                    openFileDialog1.InitialDirectory = getDirectory(filePath);
                }
                Stream fotoPerfilArchivo = openFileDialog1.OpenFile();
                Image fotoPerfil = Image.FromStream(fotoPerfilArchivo);

                pictureBox1.Image = fotoPerfil;
                fotoPerfilArchivo.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtCuit.Text = "";
            txtCalle.Text = "";
            txtNroCalle.Text = "";
            txtBarrio.Text = "";
            txtPiso.Text = "";
            txtDepto.Text = "";
            txtLocalidad.Text = "";
            txtMail.Text = "";
            txtNroEmergencia.Text = "";
            txtNroContacto.Text = "";
            txtObraSocial.Text = "";
            txtSalario.Text = "";
            dtpfechaNacimiento.Value = DateTime.Now;
            cmbEstados.SelectedIndex = -1;
            cmbPuesto.SelectedIndex = -1;
            //foto de perfil JUANSE

        }

        private void chkIngresaHoy_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIngresaHoy.Checked)
            {
                dtpFechaingreso.Enabled = false;
            }
            else
            {
                dtpFechaingreso.Enabled = true;
            }
        }

        private void txtDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtCuit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtLegajoResponsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNroContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNroEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtPiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void txtNroCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void cmbPuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEstados_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtpfechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dtpFechaingreso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
