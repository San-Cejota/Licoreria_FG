using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Licoreria_FG
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
        }
        private DataGridView dtgvLista;
        public DataGridView DtgvLista1 { get => dtgvLista; set => dtgvLista = value; }
        public void DT_lista()
        {
            dtgvLista = DtgvLista1;
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
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Administrador_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

            this.Close();
            Login l = new Login();
            l.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Caja c = new Caja();
            c.lbMensaje.Text = lbUsuarioAdm.Text;
            c.Show();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            openChildForm(new trabajadores());
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
