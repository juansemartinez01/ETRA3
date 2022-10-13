﻿using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DomainA;
using System.Diagnostics;
using System.Data.Common;
using PresentationA.Controls;

namespace PresentationA.Colaboradores.Consulta
{
    public partial class frmHistorialEvento : frmHijo
    {
        Eventos obje = new Eventos();
        DataTable historial;
        DocumentosColaborador nuevoDocumento = new DocumentosColaborador();
        
        public frmHistorialEvento(string legajo)
        {
            
            InitializeComponent();
            openFileDialog1.InitialDirectory = "no seleccionado";
            nuevoDocumento.LegajoColaborador = int.Parse(legajo);
            CargarDG(legajo);
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;
            btnVerArchivo.Enabled = false;
            lblTipoArchivo.Visible = false;
            btnAgregarArchivo.Visible = false;
            cmbTipoMultimedia.Visible = false;
            LlenarCombo(cmbTipoEvento, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoEvento WHERE borradoLogico = 0"), "nombre", "id_tipoEvento");
            LlenarCombo(cmbTipoMultimedia, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoMultimedia WHERE borradoLogico = 0"), "nombre", "id_tipoMultimedia");
            dtpfechaInicio.Format = DateTimePickerFormat.Custom;
            dtpfechaInicio.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            dtpfechaFin.Format = DateTimePickerFormat.Custom;
            dtpfechaFin.CustomFormat = "dd/MM/yyyy hh:mm:ss";

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
                dgvEventos.Rows.Clear();
                historial = obje.obtenerEventos(legajo);
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
            obje.FilaSeleccionadaHistorialEvento = indice;
            if (indice == -1)
            {
                btnVerArchivo.Enabled = false;
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
            //completarLabels(this, historial, "txt");
            cmbTipoEvento.Text = filaSeleccionada.Cells["Tipo"].Value.ToString();
            dtpfechaInicio.Text = filaSeleccionada.Cells["fechaDeInicio"].Value.ToString();
            dtpfechaFin.Text = filaSeleccionada.Cells["fechaFin"].Value.ToString();
            dtpfechaRegistro.Text = filaSeleccionada.Cells["fechaRegistro"].Value.ToString();
            txtDescripcion.Text = filaSeleccionada.Cells["descripcion"].Value.ToString();
            btnVerArchivo.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

        }

        

        private void iconButton1_Click(object sender, EventArgs e)
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
        public void agregarArchivoEvento()
        {

            
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
            nuevoDocumento.Nombre = "ArchivoCualquiera";
            nuevoDocumento.Documento = archivo;
            nuevoDocumento.Extension = openFileDialog1.SafeFileName;
            nuevoDocumento.Id_tipoMultimedia = cmbTipoMultimedia.SelectedIndex;           
            //Despues arreglar bien esto!!!!!
            int idEvento = int.Parse(obje.buscarUltimoEvento());
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
                    string respuesta = obje.InsertarEventos((int)cmbTipoEvento.SelectedValue, nuevoDocumento.LegajoColaborador, txtDescripcion.Text.ToString(), dtpfechaInicio.Value.Date, dtpfechaInicio.Value.Date);
                    if (openFileDialog1.InitialDirectory != "no seleccionado")
                    {

                        agregarArchivoEvento();
                    }
                    MessageBox.Show(respuesta);
                    CargarDG(nuevoDocumento.LegajoColaborador.ToString());
                }
                else
                {
                    string respuesta = obje.InsertarEventos((int)cmbTipoEvento.SelectedValue, nuevoDocumento.LegajoColaborador, txtDescripcion.Text.ToString(), dtpfechaInicio.Value.Date, dtpfechaFin.Value.Date);
                    if (openFileDialog1.InitialDirectory != "no seleccionado")
                    {

                        agregarArchivoEvento();
                    }
                    MessageBox.Show(respuesta);
                    CargarDG(nuevoDocumento.LegajoColaborador.ToString());
                }
                btnAgregar.Text = "Agregar";
                switchButtons(false);
                return;
            }
            btnAgregar.Text = "Guardar";
            switchButtons(true);
            


        }

        private void btnVerArchivo_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = obje.FilaSeleccionadaHistorialEvento;
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
            int indice = obje.FilaSeleccionadaHistorialEvento;
            if (indice == -1)
            {
                return;
            }
            //Utilizar metodo cargar labels, modificarlo para que envie el prefijo del nombre de la columna {lbl,txt}
            DataGridViewRow filaSeleccionada = dgvEventos.Rows[indice];
            int idEvento = int.Parse(filaSeleccionada.Cells["Numero"].Value.ToString());
            string mensaje = obje.eliminarEvento(idEvento);
            MessageBox.Show(mensaje);
            CargarDG(nuevoDocumento.LegajoColaborador.ToString());
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (btnModificar.Text == "Guardar")
            {
                //Guardar cambios, resetear estado de botones
                btnModificar.Text = "Modificar";
                btnAgregar.Enabled = true;
                switchButtons(false);
                return;
                //query guardar cambios JUANSE
            }
            // Habilitar todos los botones
            btnModificar.Text = "Guardar";
            btnAgregar.Enabled = false;
            switchButtons(true);
        }
        private void switchButtons(bool value)
        {
            if (value == false)
            {
                cmbTipoEvento.SelectedItem = null;
                dtpfechaInicio.Value = DateTime.Now;
                dtpfechaFin.Value = DateTime.Now;
                dtpfechaRegistro.Value = DateTime.Now;
                txtDescripcion.Text = null;
                lblTipoArchivo.Visible = value;
                btnAgregarArchivo.Visible = value;
                cmbTipoMultimedia.Visible = value;
            }
            cmbTipoEvento.Enabled = value;
            dtpfechaInicio.Enabled = value;
            dtpfechaFin.Enabled = value;
            dtpfechaRegistro.Enabled = value;
            txtDescripcion.Enabled = value;
            lblTipoArchivo.Visible = value;
            btnAgregarArchivo.Visible = value;
            cmbTipoMultimedia.Visible = value;
            dgvEventos.CurrentRow.Selected = false;
        }

       

        
    }
}
