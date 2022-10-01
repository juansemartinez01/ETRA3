
using PresentationA.Colaboradores;
using System;
using System.Drawing;
using System.Windows.Forms;
using DomainA;
using FontAwesome.Sharp;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Point = Microsoft.Reporting.Map.WebForms.BingMaps.Point;

namespace PresentationA
{
    public partial class frmPrincipal : Form
    {
        NotifiacacionesGeneralesModelo notifiacaciones = new NotifiacacionesGeneralesModelo();
        private IconButton botonSeleccionado;
        private Panel bordeInferior;
        public frmPrincipal()
        {

            InitializeComponent();
            hideSubMenu();
            openChildFormInPanel(new frmInicio());
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(200, 2);
            pnlPrincipal.Controls.Add(bordeInferior);
            string[] cumpleañosCercanosColaboradores = notifiacaciones.notificacionesDeCumpleaños();
            string textoConCumpleaños = "";
            foreach (string linea in cumpleañosCercanosColaboradores)
            {
                textoConCumpleaños += linea;
            }
            //MessageBox.Show(textoConCumpleaños);


            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            

        }
        private void ActivateButton(object button)
        {
            if (button != null)
            {
                DisableButton();
                botonSeleccionado = (IconButton)button;
                botonSeleccionado.ForeColor = Color.FromArgb(247, 160, 85);
                botonSeleccionado.BackColor = Color.White;
                botonSeleccionado.Font = new Font(botonSeleccionado.Font.Name, botonSeleccionado.Font.Size, FontStyle.Bold);
                botonSeleccionado.IconColor = Color.FromArgb(247, 160, 85);

                bordeInferior.BackColor = Color.FromArgb(247, 160, 85);
                bordeInferior.Location = new System.Drawing.Point(botonSeleccionado.Location.X, botonSeleccionado.Location.Y + (botonSeleccionado.Height - 5));
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (botonSeleccionado != null)
            {
                bordeInferior.Visible = false;
                botonSeleccionado.ForeColor = Color.White;
                botonSeleccionado.IconColor = Color.White;
                botonSeleccionado.BackColor = Color.FromArgb(247, 160, 85);
                botonSeleccionado.Font = new Font(botonSeleccionado.Font.Name, botonSeleccionado.Font.Size, FontStyle.Regular);
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            //Backup backup = new Backup();
            //MessageBox.Show(backup.GenerarBackup());
            ColaboradorModelo colaboradorModelo = new ColaboradorModelo();
            string eliminacionColaboradores = colaboradorModelo.EliminarColaboradorPermanentemente();

            base.OnFormClosing(e);
        }

        private void hideSubMenu()
        {
            //if (pnlColaboradores.Visible == true) pnlColaboradores.Visible = false;
            pnlColaboradores.Visible = false;
            pnlReportes.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Controls.Add(bordeInferior);
                subMenu.Visible = true;
            }
            else

                subMenu.Visible = false;
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            DisableButton();
            showSubMenu(pnlColaboradores);
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlChildForm.Controls.Add(childForm);
            pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }




        private void btnConsultar_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new FormularioColaborador());
        }

        private void btnAgregarColab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmCargaColab());
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DisableButton();
            hideSubMenu();
            openChildFormInPanel(new frmInicio());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmEventos());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            DisableButton();
            showSubMenu(pnlReportes);
        }

        private void btnSalXCargo_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new Reports.frmSalXCargo());
        }

        private void btnTardanzas_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new Reports.Tardanzas.frmTardanza());
        }

        private void btnSalarios_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmSalarios());
        }

        
    }
}
