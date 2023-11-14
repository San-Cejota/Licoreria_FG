using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Licoreria_FG
{
    public partial class Usuario : Form
    {
        public Usuario()
        {

            InitializeComponent();
            Personalizar();
        }
        private void Personalizar()
        {
            panelVinos.Visible = false;
            panelLicores.Visible = false;
            panelCervezas.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panelVinos.Visible == true)
                panelVinos.Visible = false;
            if (panelLicores.Visible == true)
                panelLicores.Visible = false;
            if (panelCervezas.Visible == true)
                panelCervezas.Visible = false;
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private Form ativoForm = null;
        private void openChildForm(Form childForm)
        {
            if (ativoForm != null)
                ativoForm.Close();
            ativoForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(childForm);
            panelContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnContacto_Click(object sender, EventArgs e)
        {
            Contacto c = new Contacto();
            c.Show();
        }

        private void btnVBlanco_Click(object sender, EventArgs e)
        {
            openChildForm(new usuBlanco());
            hideSubMenu();
        }

        private void btnChampaña_Click(object sender, EventArgs e)
        {
            openChildForm(new usuChampañas());
            hideSubMenu();
        }

        private void btnEspumoso_Click(object sender, EventArgs e)
        {
            openChildForm(new usuEspumosos());
            hideSubMenu();
        }

        private void btnRon_Click(object sender, EventArgs e)
        {
            openChildForm(new usuRones());
            hideSubMenu();
        }

        private void btnVodka_Click(object sender, EventArgs e)
        {
            openChildForm(new usuVodka());
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            openChildForm(new usuAguardientes());
            hideSubMenu();
        }

        private void btnCerveza_Nacional_Click(object sender, EventArgs e)
        {
            openChildForm(new usuNacionales());
            hideSubMenu();
        }

        private void btnEnergizantes_Click(object sender, EventArgs e)
        {
            openChildForm(new usuEnergizantes());
            hideSubMenu();
        }

        private void btnVinos_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelVinos);
        }

        private void btnLicores_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelLicores);
        }

        private void btnTequilas_Click(object sender, EventArgs e)
        {
            openChildForm(new usuTequilas());
        }

        private void btnCervezas_Click(object sender, EventArgs e)
        {
            mostrarSubMenu(panelCervezas);
        }

        private void btnAlimentos_Click(object sender, EventArgs e)
        {
            openChildForm(new usuAlimentos());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Login l = new Login();
            l.Show();

        }
    }
}
