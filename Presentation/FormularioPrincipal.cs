using Presentation.Colaboradores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using FontAwesome.Sharp;

namespace Presentation
{
    public partial class FormularioPrincipal : Form
    {
        private IconButton botonSeleccionado;
        private Panel bordeInferior;
        public FormularioPrincipal()
        {
            
            InitializeComponent();
            customizeDesign();
            openChildFormInPanel(new frmInicio());
            bordeInferior = new Panel();
            bordeInferior.Size = new Size(200, 2);
            pnlSideMenu.Controls.Add(bordeInferior);
            pnlColaboradores.Controls.Add(bordeInferior);

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
                bordeInferior.Location = new Point(botonSeleccionado.Location.X, botonSeleccionado.Location.Y+35);
                bordeInferior.Visible = true;
                bordeInferior.BringToFront();
            }
        }
        private void DisableButton()
        {
            if (botonSeleccionado != null)
            {
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

        private void customizeDesign()
        {
            pnlColaboradores.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pnlColaboradores.Visible == true) pnlColaboradores.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                
                subMenu.Visible = true;
            }
            else
                
                subMenu.Visible = false;
        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            
            showSubMenu(pnlColaboradores);
        }

        private void FormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        { 
        }

        private void btnAgregarColab_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmCargaColab());
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmInicio());
        }

        private void btnEventos_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            openChildFormInPanel(new frmEventos());
        }
    }
}
