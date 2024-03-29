﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DomainA;
using System.Diagnostics;
using Common.Cache;
using Microsoft.Office.Interop.Excel;


namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmHistorialEvento : frmHijo
    {
        EventosModelo eventosModelo = new EventosModelo();
        System.Data.DataTable historial;
        DocumentosColaborador nuevoDocumento = new DocumentosColaborador();
        
        public frmHistorialEvento(string legajo)
        {
            
            InitializeComponent();
            openFileDialog1.InitialDirectory = "no seleccionado";
            nuevoDocumento.LegajoColaborador = int.Parse(legajo);
            CargarDG(legajo, false);
            LlenarCombo(cmbTipoEvento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            LlenarCombo(cmbTipoMultimedia, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMultimedia WHERE borradoLogico = 0"), "nombre", "id_tipoMultimedia");
            dtpfechaInicio.Format = DateTimePickerFormat.Custom;
            dtpfechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpfechaFin.Format = DateTimePickerFormat.Custom;
            dtpfechaFin.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            ViewState();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        private void CargarDG(string legajo,bool soloPagosSueldo)
        {
            try
            {
                dgvEventos.Rows.Clear();
                historial = eventosModelo.obtenerEventos(legajo, soloPagosSueldo);
                for (int i = 0; i < historial.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvEventos.Rows.Add(historial.Rows[i]["Tipo"], historial.Rows[i]["Descripción"], historial.Rows[i]["Fecha de Inicio"], historial.Rows[i]["Fecha Fin"], historial.Rows[i]["Fecha de Registro"], historial.Rows[i]["Numero"]);
                }
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dgvEventos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            eventosModelo.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                btnVerArchivo.Visible = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
            //completarLabels(this, historial, "txt");
            ViewState();
            
            //Juanse resolver el tipo de paretenzco
            cmbTipoEvento.SelectedValue = eventosModelo.buscarIdConNombre(filaSeleccionada.Cells["Tipo"].Value.ToString(), "TipoEvento");
            dtpfechaInicio.Text = filaSeleccionada.Cells["fechaDeInicio"].Value.ToString();
            dtpfechaFin.Text = filaSeleccionada.Cells["fechaFin"].Value.ToString();
            dtpfechaRegistro.Text = filaSeleccionada.Cells["fechaRegistro"].Value.ToString();
            txtDescripcion.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
            
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
            string variableMuerta = nuevoDocumento.AgregarDocumento(nuevoDocumento.Nombre, nuevoDocumento.Documento, nuevoDocumento.Extension, nuevoDocumento.Id_tipoMultimedia, nuevoDocumento.LegajoColaborador, idEvento);

            //Parte para ver la imagen
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text == "Guardar")
            {
                // guardar nuevo valor
                if (cmbTipoEvento.SelectedIndex == -1)
                {
                    MessageBox.Show("Debe seleccionar primero el tipo de evento que quiere crear");
                    return;
                }
                if ((int)cmbTipoEvento.SelectedValue == 2)
                {
                    string respuesta = eventosModelo.InsertarEventos((int)cmbTipoEvento.SelectedValue, nuevoDocumento.LegajoColaborador, txtDescripcion.Text.ToString(), dtpfechaInicio.Value.Date, dtpfechaInicio.Value.Date);
                    if (openFileDialog1.InitialDirectory != "no seleccionado")
                    {

                        agregarArchivoEvento(0);
                    }

                    MessageBox.Show(respuesta);
                    CargarDG(nuevoDocumento.LegajoColaborador.ToString(),false);
                    
                }
                else
                {
                    string respuesta = eventosModelo.InsertarEventos((int)cmbTipoEvento.SelectedValue, nuevoDocumento.LegajoColaborador, txtDescripcion.Text.ToString(), dtpfechaInicio.Value.Date, dtpfechaFin.Value.Date);
                    if (openFileDialog1.InitialDirectory != "no seleccionado")
                    {

                        agregarArchivoEvento(0);
                    }
                    MessageBox.Show(respuesta);
                    CargarDG(nuevoDocumento.LegajoColaborador.ToString(), false);
                    
                }
                ViewState();
                return;
            }
            AddState();
        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = eventosModelo.FilaSeleccionadaHistorialEvento;
                if (indice == -1)
                {
                    return;
                }
                //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
                DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
                int idEvento = int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
                var Lista = new List<DocumentosColaborador>();
                Lista = nuevoDocumento.filtroDocumentosEvento(idEvento);
                if (Lista.Count == 0)
                {
                    MessageBox.Show("No hay ningun archivo asociado a este evento");
                    return;
                }

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

                Stream archivo = File.OpenRead(ubicacionCompleta);

                Process.Start(ubicacionCompleta);


                archivo.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int indice = eventosModelo.FilaSeleccionadaHistorialEvento;
            if (indice == -1)
            {
                return;
            }
            if(MessageBox.Show("Esta seguro que desea eliminar el evento?","Elminar Evento",MessageBoxButtons.YesNo) == DialogResult.No) { ViewState(); return; }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
            int idEvento = int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
            string mensaje = eventosModelo.eliminarEvento(idEvento);
            MessageBox.Show(mensaje);
            CargarDG(nuevoDocumento.LegajoColaborador.ToString(), false);
            ViewState();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (btnModificar.Text == "Guardar")
            {
                //Guardar cambios, resetear estado de botones
                
                int indice = eventosModelo.FilaSeleccionadaHistorialEvento;
                if (indice == -1)
                {
                    ViewState();
                    return;
                }
                if(cmbTipoEvento.SelectedValue == null) { MessageBox.Show("Debe seleccionar un tipo de evento");ViewState(); return; }
                //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
                //Error, controlar if con indice menor a cero, juanse no sabe nada ni testear puede
                DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
                int idEvento = int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
                
                if (cmbTipoMultimedia.SelectedIndex != -1)
                {
                    agregarArchivoEvento(idEvento);
                }
                
                string mensaje = eventosModelo.modificarEvento(idEvento, (int)cmbTipoEvento.SelectedValue, dtpfechaInicio.Value.Date, dtpfechaFin.Value.Date, dtpfechaRegistro.Value.Date, txtDescripcion.Text.ToString());
                MessageBox.Show(mensaje);
                CargarDG(nuevoDocumento.LegajoColaborador.ToString(), false);
                ViewState();
                return;
            }
            ModifyState();
        }

        private void frmHistorialEvento_Load(object sender, EventArgs e)
        {
            if (UserCache.perfil != Perfiles.admin) 
            {
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAgregarArchivo.Enabled = false;
            }
        }

        private void AddState()
        {
            //Vaciar lo que sea que haya en en archivos, sino se guarda de movimiento anterior, JUANSE
            dtpfechaFin.Enabled = true;
            dtpfechaInicio.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbTipoEvento.Enabled = true;
            lblTipoArchivo.Visible = true;
            cmbTipoMultimedia.Visible = true;
            cmbTipoMultimedia.Location = new System.Drawing.Point(lblTipoArchivo.Location.X + 139, lblTipoArchivo.Location.Y);
            btnAgregarArchivo.Visible = true;
            btnAgregarArchivo.Location = new System.Drawing.Point(lblTipoArchivo.Location.X + 184, lblTipoArchivo.Location.Y + 41);
            btnCancelar.Visible = true;
            btnCancelar.Location = new System.Drawing.Point(btnAgregar.Location.X + 357, btnAgregar.Location.Y - 63);

            dtpfechaInicio.Value = DateTime.Now;
            dtpfechaFin.Value = DateTime.Now;
            dtpfechaRegistro.Value = DateTime.Now;
            txtDescripcion.Text = null;
            cmbTipoEvento.Text = null;

            btnVerArchivo.Visible = false;  
            btnAgregar.Text = "Guardar";
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;

            btnModificar.Visible = false;
            btnEliminar.Visible = false;

            if (dgvEventos.CurrentRow != null) { dgvEventos.CurrentRow.Selected = false; }
            dgvEventos.Enabled = false;
            return;
        }
        private void ViewState()
        {
            dtpfechaFin.Enabled = false;
            dtpfechaInicio.Enabled = false;
            txtDescripcion.Enabled = false;
            cmbTipoEvento.Enabled = false;
            lblTipoArchivo.Visible = false;
            cmbTipoMultimedia.Visible = false;
            btnAgregarArchivo.Visible = false;
            btnCancelar.Visible = false;
            dtpfechaInicio.Value = DateTime.Now;
            dtpfechaFin.Value = DateTime.Now;
            dtpfechaRegistro.Value = DateTime.Now;
            txtDescripcion.Text = null;
            cmbTipoEvento.Text = null;
            cmbTipoMultimedia.Text = null;

            btnVerArchivo.Visible = true;

            btnAgregar.Text = "Agregar";
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;

            btnModificar.Text = "Modificar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.Pen;


            btnAgregar.Visible = true;
            bool aux = true;
            if (dgvEventos.CurrentCell == null) { aux = false; }

            btnModificar.Visible = aux;
            btnModificar.Location = new System.Drawing.Point(btnAgregar.Location.X + 177, btnAgregar.Location.Y);
            btnEliminar.Visible = aux;
            btnEliminar.Location = new System.Drawing.Point(btnAgregar.Location.X + 357, btnAgregar.Location.Y);
            btnVerArchivo.Visible = aux;
            btnVerArchivo.Location = new System.Drawing.Point(btnAgregar.Location.X + 133, btnAgregar.Location.Y - 63);
            
            btnAgregar.Enabled = true;
            btnModificar.Enabled = aux;
            btnEliminar.Enabled = aux;
            btnVerArchivo.Enabled = aux;

            dgvEventos.Enabled = true;
            return;
        }
        private void ModifyState()
        {
            //Vaciar lo que sea que haya en en archivos, sino se guarda de movimiento anterior, JUANSE

            if (cmbTipoEvento.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de evento");
                return;
            }
            dtpfechaFin.Enabled = true;
            dtpfechaInicio.Enabled = true;
            txtDescripcion.Enabled = true;
            cmbTipoEvento.Enabled = true;
            lblTipoArchivo.Visible = true;
            cmbTipoMultimedia.Visible = true;
            cmbTipoMultimedia.Location = new System.Drawing.Point(lblTipoArchivo.Location.X + 139, lblTipoArchivo.Location.Y);
            btnAgregarArchivo.Visible = true;
            btnAgregarArchivo.Location = new System.Drawing.Point(lblTipoArchivo.Location.X + 184, lblTipoArchivo.Location.Y + 41);
            btnCancelar.Visible = true;
            btnCancelar.Location = new System.Drawing.Point(btnAgregar.Location.X + 357, btnAgregar.Location.Y - 63);

            btnVerArchivo.Visible = false;
            btnEliminar.Visible = false;
            btnAgregar.Visible = false;
            btnAgregar.Text = "Agregar";
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            
            btnModificar.Visible = true;
            btnModificar.Text = "Guardar";
            btnModificar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;

            dgvEventos.Enabled = false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if(dgvEventos.Rows.Count > 0) {   dgvEventos.Rows[dgvEventos.CurrentRow.Index].Selected = true;  }
            ViewState();
        }

        private void cmbTipoEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
