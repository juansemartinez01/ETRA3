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


namespace Presentation
{
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            
            InitializeComponent();
            customizeDesign();
            
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Backup backup = new Backup();
            MessageBox.Show(backup.GenerarBackup());

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

            openChildFormInPanel(new FormularioColaborador());
        }

        private void button4_Click(object sender, EventArgs e)
        { 
        }

        private void btnAgregarColab_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new frmCargaColab());
        }

        
    }
}
