using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomainA;


namespace PresentationA.Colaboradores
{
    public partial class frmAvisos : frmHijo
    {
        NotifiacacionesGeneralesModelo notificacion = new NotifiacacionesGeneralesModelo();
        AvisosModelo avisosModelo = new AvisosModelo();
        
        public frmAvisos()
        {
            InitializeComponent();
            cargarAvisos(0, 0, "", "", "", false);

            LlenarCombo(cmbColaborador, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Colaborador WHERE borradoLogico = 0"), "legajo", "legajo");
            LlenarCombo(cmbTipoAvisoFiltro, DataManager.GetInstance().ConsultaSQL("SELECT * FROM TipoAviso WHERE borradoLogico = 0"), "nombre", "id_tipoAviso");
            chkFiltroFecha.Enabled = true;
            dtpfechaCargaFiltro.Enabled = false;
            dtpfechaNotifiaciónFiltro.Enabled = false;
            dtpfechaOcurrenciaFiltro.Enabled = false;
            ViewState();
        }
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.ValueMember = value;
            cbo.DisplayMember = display;
            cbo.DataSource = source;
            cbo.SelectedIndex = -1;
        }
        public void cargarGrillasCumpleaños()
        {
            DataTable cumpleañosColaboradores = new DataTable();
            DataTable cumpleañosFamiliares = new DataTable();
            try
            {
                dgvAvisos.Rows.Clear();
                cumpleañosColaboradores = notificacion.notificacionesDeCumpleaños();
                for (int i = 0; i < cumpleañosColaboradores.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvAvisos.Rows.Add(cumpleañosColaboradores.Rows[i]["Nombre"], cumpleañosColaboradores.Rows[i]["Apellido"], cumpleañosColaboradores.Rows[i]["Cumpleaños"]);
                }
                
                cumpleañosFamiliares = notificacion.cumpleañosFamiliaresColaboradores();
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void cargarAvisos(int legajo,int idTipoAviso, string fechaOcurrencia,string fechaCarga,string fechaNotificacion,bool filtroFecha)
        {
            //Tenemos que traer la tabla segun los valores ingresados en el filtro, en un principio solo traemos todos los avisos
            DataTable avisos = avisosModelo.getAllAvisos(legajo, idTipoAviso, fechaOcurrencia,fechaCarga,fechaNotificacion,filtroFecha);
            try
            {
                dgvAvisos.Rows.Clear();
                
                for (int i = 0; i < avisos.Rows.Count; i++)
                {
                    //crear metodo completar labels
                    dgvAvisos.Rows.Add(avisos.Rows[i]["id_aviso"],avisos.Rows[i]["nombre"], avisos.Rows[i]["legajo"], avisos.Rows[i]["fechaOcurrencia"], avisos.Rows[i]["descripcion"], avisos.Rows[i]["fechaCarga"], avisos.Rows[i]["fechaNotificacion"], avisos.Rows[i]["fechaUltimaNotificacion"]);
                }
                  
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        

        private void chkFiltroFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFiltroFecha.Checked == true)
            {
                dtpfechaCargaFiltro.Enabled = true;
                dtpfechaNotifiaciónFiltro.Enabled = true;
                dtpfechaOcurrenciaFiltro.Enabled = true;
            }
            else
            {
                dtpfechaCargaFiltro.Enabled = false;
                dtpfechaNotifiaciónFiltro.Enabled = false;
                dtpfechaOcurrenciaFiltro.Enabled = false;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            string fechaCarga = dtpfechaCargaFiltro.Value.ToString("yyyy/MM/dd");
            string fechaNotificacion = dtpfechaNotifiaciónFiltro.Value.ToString("yyyy/MM/dd");
            string fechaOcurrencia = dtpfechaOcurrenciaFiltro.Value.ToString("yyyy/MM/dd");
            int colaboradorFiltro = 0;
            int tipoAvisofiltro = 0;
            bool filtroFecha = false;

            if(cmbColaborador.SelectedIndex != -1)
            {
                colaboradorFiltro = int.Parse(cmbColaborador.SelectedValue.ToString());
            }
            if(cmbTipoAvisoFiltro.SelectedIndex != -1)
            {
                tipoAvisofiltro = int.Parse(cmbTipoAvisoFiltro.SelectedValue.ToString());
            }
            if (chkFiltroFecha.Checked)
            {
                filtroFecha = true;
            }
            cargarAvisos(colaboradorFiltro, tipoAvisofiltro, fechaOcurrencia, fechaCarga, fechaNotificacion, filtroFecha);
        }
        public void limpiarCampos()
        {
            cmbColaborador.SelectedIndex = -1;
            cmbTipoAvisoFiltro.SelectedIndex = -1;
            dtpfechaCargaFiltro.Value = DateTime.Now;
            dtpfechaNotifiaciónFiltro.Value = DateTime.Now;
            dtpfechaOcurrenciaFiltro.Value = DateTime.Now;
            chkFiltroFecha.Checked = false;

        }

        private void btnNotificar_Click(object sender, EventArgs e)
        {
            if(dgvAvisos.SelectedRows.Count == 1)
            {
                frmMail mail = new frmMail((int)dgvAvisos.SelectedRows[0].Cells["id_aviso"].Value);
                mail.ShowDialog();
            }
            
        }

        private void ViewState()
        {
            
            bool aux = true;
            if (dgvAvisos.CurrentCell == null) { aux = false; }

            btnEliminar.Enabled = aux;
            btnNotificar.Enabled = aux;
            dgvAvisos.Enabled = true;
        }

        private void dgvAvisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indice = e.RowIndex;
            if (indice == -1)
            {
                btnNotificar.Enabled = false;
                btnEliminar.Enabled = false;
                return;
            }
            ViewState();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoAviso frm = new frmNuevoAviso();
            frm.ShowDialog();
            cargarAvisos(0, 0, "", "", "", false);
        }

        private void frmAvisos_Load(object sender, EventArgs e)
        {
            cargarAvisos(0, 0, "", "", "", false);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int colaboradoresAfectados = 0;
            if (dgvAvisos.SelectedRows.Count == 1)
            {
                int idAviso = (int)dgvAvisos.SelectedRows[0].Cells["id_aviso"].Value;
                colaboradoresAfectados = avisosModelo.eliminarAvisoLogico(idAviso);
                if(colaboradoresAfectados > 0)
                {
                    MessageBox.Show("Se elimino correctamente el aviso. El aviso estaba relacionado a " + colaboradoresAfectados + " colaboradores.");
                }
                else
                {
                    MessageBox.Show("Hubo un error al eliminar el aviso.");
                }
            }
        }
    }
}
